<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Log POST data for debugging purposes
    file_put_contents('upload_log.txt', 'POST data: ' . json_encode($_POST) . PHP_EOL, FILE_APPEND);

    // Check for the required parameters
    if (isset($_POST['student_id'], $_POST['fileName'], $_POST['fileContent'])) {
        $studentId = trim(htmlspecialchars(strip_tags($_POST['student_id'])));
        $fileName = htmlspecialchars(strip_tags($_POST['fileName']));
        $fileContent = $_POST['fileContent'];

        file_put_contents('upload_log.txt', "Checking student_id: $studentId" . PHP_EOL, FILE_APPEND);

        // Validate student ID
        if (empty($studentId)) {
            echo json_encode(["status" => "error", "message" => "Student ID is empty"]);
            exit;
        }

        // Sanitize the file name and prevent directory traversal
        $fileName = basename($fileName);

        // Decode the base64 file content
        $decodedFileContent = base64_decode($fileContent);
        if ($decodedFileContent === false) {
            echo json_encode(["status" => "error", "message" => "Failed to decode file content"]);
            exit;
        }

        // Set up upload directory
        $uploadDir = 'uploads/';
        if (!is_dir($uploadDir)) {
            mkdir($uploadDir, 0777, true);
        }

        $filePath = $uploadDir . $fileName;

        // Save the decoded file
        if (file_put_contents($filePath, $decodedFileContent) !== false) {
            chmod($filePath, 0644); // Set appropriate file permissions

            // Database connection
            $conn = new mysqli("localhost", "root", "", "tua_ojt_monitoring");
            if ($conn->connect_error) {
                file_put_contents('upload_log.txt', "DB Connection Error: " . $conn->connect_error . PHP_EOL, FILE_APPEND);
                echo json_encode(["status" => "error", "message" => "Database connection failed"]);
                exit;
            }

            // Check if the student ID exists in the database
            $checkStudentStmt = $conn->prepare("SELECT COUNT(*) FROM students WHERE student_id = ?");
            $checkStudentStmt->bind_param("s", $studentId);
            $checkStudentStmt->execute();
            $checkStudentStmt->bind_result($studentExists);
            $checkStudentStmt->fetch();
            $checkStudentStmt->close();

            if ($studentExists == 0) {
                file_put_contents('upload_log.txt', 'Student ID does not exist in DB' . PHP_EOL, FILE_APPEND);
                echo json_encode(["status" => "error", "message" => "Student ID does not exist"]);
                exit;
            }

            // Insert file data into the database along with the current date for report_date
            $stmt = $conn->prepare("INSERT INTO accomplishment_reports (student_id, content, report_date) VALUES (?, ?, NOW())");
            $stmt->bind_param("ss", $studentId, $filePath);

            if ($stmt->execute()) {
                // Return success response
                echo json_encode(["status" => "success", "message" => "File uploaded successfully", "filePath" => $filePath]);
            } else {
                file_put_contents('upload_log.txt', 'DB Insert Error: ' . $stmt->error . PHP_EOL, FILE_APPEND);
                echo json_encode(["status" => "error", "message" => "Database insert failed"]);
            }

            $stmt->close();
            $conn->close();
        } else {
            file_put_contents('upload_log.txt', 'File Upload Error: Could not save file to ' . $filePath . PHP_EOL, FILE_APPEND);
            echo json_encode(["status" => "error", "message" => "File upload failed"]);
        }
    } else {
        echo json_encode(["status" => "error", "message" => "Missing parameters"]);
    }
} else {
    echo json_encode(["status" => "error", "message" => "Invalid request method"]);
}
?>
