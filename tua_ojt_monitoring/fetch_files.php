<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (isset($_POST['student_id'])) {
        $studentId = $_POST['student_id'];

        // Database connection
        $conn = new mysqli("localhost", "root", "", "tua_ojt_monitoring");

        // Check connection
        if ($conn->connect_error) {
            echo json_encode(["status" => "error", "message" => "Connection failed: " . $conn->connect_error]);
            exit;
        }

        // Query to fetch files submitted by the student
        $stmt = $conn->prepare("SELECT student_id, content FROM accomplishment_reports WHERE student_id = ?");
        if ($stmt === false) {
            echo json_encode(["status" => "error", "message" => "Failed to prepare the SQL statement"]);
            $conn->close();
            exit;
        }

        $stmt->bind_param("s", $studentId);
        if (!$stmt->execute()) {
            echo json_encode(["status" => "error", "message" => "Error executing query: " . $stmt->error]);
            $stmt->close();
            $conn->close();
            exit;
        }

        $result = $stmt->get_result();
        $files = [];

        while ($row = $result->fetch_assoc()) {
            $files[] = [
                'fileName' => basename($row['content']),  // Get just the filename from the content path
                'fileUri' => $row['content'],             // Path to file in server
            ];
        }

        if (count($files) > 0) {
            echo json_encode(["status" => "success", "files" => $files]);
        } else {
            echo json_encode(["status" => "error", "message" => "No files found"]);
        }

        $stmt->close();
        $conn->close();
    } else {
        echo json_encode(["status" => "error", "message" => "Missing student_id parameter"]);
    }
} else {
    echo json_encode(["status" => "error", "message" => "Invalid request method"]);
}
?>
