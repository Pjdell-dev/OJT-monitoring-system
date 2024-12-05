<?php
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

include "ojt_connect.php"; // Make sure this file connects to your DB correctly

header('Content-Type: application/json');

// Debugging: Log all inputs to check what is being sent
file_put_contents("php://stderr", print_r($_POST, true));

if (isset($_POST['user_id'])) {
    $user_id = $_POST['user_id'];

    // Query to fetch the logs for a specific user_id
    $query = "
        SELECT t.date, t.time_in, t.time_out
        FROM time_in t
        JOIN students s ON t.student_id = s.student_id
        JOIN users u ON s.user_id = u.user_id
        WHERE u.user_id = ?
    ";

    // Prepare and execute the query
    if ($stmt = mysqli_prepare($conn, $query)) {
        mysqli_stmt_bind_param($stmt, "s", $user_id);
        mysqli_stmt_execute($stmt);
        $result = mysqli_stmt_get_result($stmt);

        $logs = [];
        while ($row = mysqli_fetch_assoc($result)) {
            $logs[] = [
                "date" => $row['date'],
                "time_in" => $row['time_in'] ?: "N/A", // Handling null values
                "time_out" => $row['time_out'] ?: "N/A" // Handling null values
            ];
        }

        // Output valid JSON
        echo json_encode($logs);
    } else {
        // Return error if the query fails
        echo json_encode(["error" => "Failed to prepare query: " . mysqli_error($conn)]);
    }
} else {
    // Return error if 'user_id' is not provided
    echo json_encode(["error" => "Invalid input. 'user_id' is required."]);
}

mysqli_close($conn);
?>
