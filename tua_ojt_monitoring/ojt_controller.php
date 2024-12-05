<?php 
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

include "ojt_connect.php";

header('Content-Type: application/json');

// Start output buffering
ob_start();

// FOR LOG IN
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (isset($_POST['logIn'])) {
        if (isset($_POST['email']) && isset($_POST['password'])) {
            $email = $_POST['email'];
            $password = $_POST['password'];

            $query = "SELECT * FROM users WHERE user_email = ? AND user_password = ?";
            $stmt = mysqli_prepare($conn, $query);
            mysqli_stmt_bind_param($stmt, 'ss', $email, $password);
            mysqli_stmt_execute($stmt);
            $result = mysqli_stmt_get_result($stmt);

            if (mysqli_num_rows($result) > 0) {
                $row = mysqli_fetch_assoc($result);
                $response = array(
                    "user_email" => $row['user_email'],
                    "user_id" => $row['user_id'],
                    "account_type" => "student"
                );
                echo json_encode($response);
            } else {
                echo json_encode(array("error" => "Invalid Username or Password."));
            }
            exit;
        } else {
            echo json_encode(array("error" => "Email or Password not set."));
            exit;
        }
    }

    // FOR HOME PAGE OR ID
    if (isset($_POST['aboutID']) && $_POST['aboutID'] === "aboutID") {
        if (isset($_POST['user_id'])) {
            $user_id = $_POST['user_id'];

            $query = "SELECT students.student_id AS studentid, students.last_name AS studentLastName, 
                             students.first_name AS studentFirstName, students.contact_number AS studentContactNum, 
                             supervisors.last_name AS supervisorLastName, supervisors.first_name AS supervisorFirstName, 
                             supervisors.company AS company 
                      FROM `students` 
                      JOIN supervisors ON students.supervisor_id = supervisors.supervisor_id 
                      JOIN users ON students.user_id = users.user_id 
                      WHERE students.user_id = ?";
            $stmt = mysqli_prepare($conn, $query);
            mysqli_stmt_bind_param($stmt, 's', $user_id);
            mysqli_stmt_execute($stmt);
            $result = mysqli_stmt_get_result($stmt);

            if (mysqli_num_rows($result) > 0) {
                $row = mysqli_fetch_assoc($result);
                $response = array(
                    "studentid" => $row['studentid'],
                    "studentLastName" => $row['studentLastName'],
                    "studentFirstName" => $row['studentFirstName'],
                    "supervisorLastName" => $row['supervisorLastName'],
                    "supervisorFirstName" => $row['supervisorFirstName'],
                    "company" => $row['company']
                );
                echo json_encode($response);
            } else {
                echo json_encode(array("error" => "No data found."));
            }
            exit;
        } else {
            echo json_encode(array("error" => "User ID not set."));
            exit;
        }
    }

    // FOR CHANGING PASSWORD
    if (isset($_POST['changePassword']) && $_POST['changePassword'] === "changePassword") {
        if (isset($_POST['user_id']) && isset($_POST['current_password']) && isset($_POST['new_password'])) {
            $user_id = $_POST['user_id'];
            $current_password = $_POST['current_password'];
            $new_password = $_POST['new_password'];

            // Verify current password
            $query = "SELECT * FROM users WHERE user_id = ? AND user_password = ?";
            $stmt = mysqli_prepare($conn, $query);
            mysqli_stmt_bind_param($stmt, 'ss', $user_id, $current_password);
            mysqli_stmt_execute($stmt);
            $result = mysqli_stmt_get_result($stmt);

            if (mysqli_num_rows($result) > 0) {
                // Update to new password
                $update_query = "UPDATE users SET user_password = ? WHERE user_id = ?";
                $update_stmt = mysqli_prepare($conn, $update_query);
                mysqli_stmt_bind_param($update_stmt, 'ss', $new_password, $user_id);

                if (mysqli_stmt_execute($update_stmt)) {
                    echo json_encode(array("success" => "Password changed successfully."));
                } else {
                    echo json_encode(array("error" => "Failed to change password."));
                }
            } else {
                echo json_encode(array("error" => "Current password is incorrect."));
            }
            exit;
        } else {
            echo json_encode(array("error" => "Required parameters not set."));
            exit;
        }
    }

    // FOR FILE UPLOAD
    if (isset($_POST['fileName']) && isset($_POST['fileContent']) && isset($_POST['user_id'])) {
        $fileName = $_POST['fileName'];
        $fileContent = $_POST['fileContent'];
        $user_id = $_POST['user_id'];

        // Save the file to the server
        $filePath = 'uploads/' . $fileName;
        file_put_contents($filePath, $fileContent);

        // Insert the file info into the database
        $query = "INSERT INTO accomplishment_reports (user_id, content, file_path) VALUES (?, ?, ?)";
        $stmt = mysqli_prepare($conn, $query);
        mysqli_stmt_bind_param($stmt, 'sss', $user_id, $fileContent, $filePath);

        if (mysqli_stmt_execute($stmt)) {
            echo json_encode(array("success" => "File uploaded and data saved successfully."));
        } else {
            echo json_encode(array("error" => "Failed to save file data to the database."));
        }
        exit;
    }

    // FOR FETCHING ALL FILES SUBMITTED
    if (isset($_POST['fetchFiles']) && $_POST['fetchFiles'] === "fetchFiles") {
        if (isset($_POST['user_id'])) {
            $user_id = $_POST['user_id'];

            $query = "SELECT file_name, file_path FROM accomplishment_reports WHERE user_id = ?";
            $stmt = mysqli_prepare($conn, $query);
            mysqli_stmt_bind_param($stmt, 's', $user_id);
            mysqli_stmt_execute($stmt);
            $result = mysqli_stmt_get_result($stmt);

            $files = [];
            while ($row = mysqli_fetch_assoc($result)) {
                $files[] = $row;
            }

            if (!empty($files)) {
                echo json_encode(array("files" => $files));
            } else {
                echo json_encode(array("error" => "No files found."));
            }
            exit;
        } else {
            echo json_encode(array("error" => "User ID not set."));
            exit;
        }
    }
}

// For Settings

if (isset($_POST['settings']) && $_POST['settings'] === "settings") {
    if (isset($_POST['user_id'])) {
        $user_id = (string)$_POST['user_id']; 

        // Corrected SQL query
        $query = "SELECT students.student_id AS studentidinfo, students.last_name AS studentLastName, 
                         students.first_name AS studentFirstName, students.contact_number AS studentContactNum, 
                         supervisors.last_name AS supervisorLastName, supervisors.first_name AS supervisorFirstName 
                  FROM `students` 
                  JOIN supervisors ON students.supervisor_id = supervisors.supervisor_id 
                  JOIN users ON students.user_id = users.user_id 
                  WHERE students.user_id = ?";
        
        // Check for successful database connection
        if ($conn === false) {
            die('Error: Unable to connect to the database.');
        }

        // Prepare the query
        $stmt = mysqli_prepare($conn, $query);
        if ($stmt === false) {
            die('MySQL error: ' . mysqli_error($conn));
        }

        // Bind the user_id parameter (make sure it's a string)
        mysqli_stmt_bind_param($stmt, 's', $user_id);  // $user_id must be a variable

        // Execute the statement
        mysqli_stmt_execute($stmt);
        $result = mysqli_stmt_get_result($stmt);

        // Check if the result is not empty
        if (mysqli_num_rows($result) > 0) {
            $row = mysqli_fetch_assoc($result);
            $response = array(
                "studentidinfo" => $row['studentidinfo'],
                "studentLastName" => $row['studentLastName'],
                "studentFirstName" => $row['studentFirstName'],
                "supervisorLastName" => $row['supervisorLastName'],
                "supervisorFirstName" => $row['supervisorFirstName'],
                "studentContactNum" => $row['studentContactNum']
            );
            echo json_encode($response);
        } else {
            echo json_encode(array("error" => "No data found."));
        }
        exit;
    } else {
        echo json_encode(array("error" => "User ID not set."));
        exit;
    }
}


echo json_encode(array("error" => "Invalid request method."));
exit;

ob_end_flush();
?>
