<?php
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

include "ojt_connect.php";

header('Content-Type: application/json');



if (isset($_POST['qr_string'], $_POST['date'], $_POST['time'], $_POST['user_id'], $_POST['is_time_in'])) {
    $qr_string = $_POST['qr_string'];
    $date = $_POST['date'];
    $time = $_POST['time'];
    $user_id = $_POST['user_id'];
    $is_time_in = $_POST['is_time_in'] === "true" ? true : false;

    // Fetch student_id from the current session using user_id
    $studentQuery = "
        SELECT s.student_id 
        FROM students s
        JOIN users u ON s.user_id = u.user_id 
        WHERE u.user_id = ?
    ";

    if ($stmt = mysqli_prepare($conn, $studentQuery)) {
        mysqli_stmt_bind_param($stmt, 's', $user_id);
        mysqli_stmt_execute($stmt);
        $result = mysqli_stmt_get_result($stmt);

        if ($row = mysqli_fetch_assoc($result)) {
            $student_id = $row['student_id'];
            $table = $is_time_in ? 'time_in' : 'time_out';  // Determine the table based on time-in or time-out action
            $time_column = $is_time_in ? 'time_in' : 'time_out'; // Use the correct column for time-in or time-out
            $updateQuery = "
                UPDATE `$table` 
                SET student_id = ?, 
                    date = ?, 
                    $time_column = ?, 
                    status = 'Present' 
                WHERE qr_string = ? AND status = 'Pending'
            ";
            if ($stmtUpdate = mysqli_prepare($conn, $updateQuery)) {
                mysqli_stmt_bind_param($stmtUpdate, 'ssss', $student_id, $date, $time, $qr_string);

                if (mysqli_stmt_execute($stmtUpdate)) {
                    echo json_encode(["success" => "Time log updated successfully."]);
                } else {
                    echo json_encode(["error" => "Failed to update time log: " . mysqli_stmt_error($stmtUpdate)]);
                }
            } else {
                echo json_encode(["error" => "Failed to prepare update statement: " . mysqli_error($conn)]);
            }
        } else {
            echo json_encode(["error" => "Student ID not found."]);
        }
        mysqli_stmt_close($stmt);
    } else {
        echo json_encode(["error" => "Failed to prepare student query: " . mysqli_error($conn)]);
    }
} else {
    echo json_encode(["error" => "Invalid input data."]);
}

mysqli_close($conn);
?>
