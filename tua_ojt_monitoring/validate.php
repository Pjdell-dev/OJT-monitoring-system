<?php
include "ojt_connect.php";
header('Content-Type: application/json');

if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['qr_string'])) {
    $qr_string = trim($_POST['qr_string']);
    $current_time = date('H:i:s'); // Current server time
    $current_date = date('Y-m-d'); // Current server date

    // Check if the QR code exists in the time_in table with a pending status
    $query = "SELECT * FROM time_in WHERE status = 'Pending' AND qr_string = ?";
    $stmt = mysqli_prepare($conn, $query);
    mysqli_stmt_bind_param($stmt, 's', $qr_string);
    mysqli_stmt_execute($stmt);
    $result = mysqli_stmt_get_result($stmt);

    if (mysqli_num_rows($result) > 0) {
        $row = mysqli_fetch_assoc($result);

        // If a pending Time-In is found, perform Time-Out
        $time_in = $row['time_in'];
        $date = $row['date'];
        
        // Store Time-Out in the time_out table
        $updateQuery = "INSERT INTO time_out (time_out, status, qr_string) VALUES (?, 'Present', ?)";
        $updateStmt = mysqli_prepare($conn, $updateQuery);
        mysqli_stmt_bind_param($updateStmt, 'ss', $qr_string, $current_time);

        if (mysqli_stmt_execute($updateStmt)) {
            // Log the data in time_logs table after successful Time-Out
            $insertLogQuery = "INSERT INTO time_logs (date, status, time_in, time_out, qr_string) VALUES (?,'Present', ?, ?, ?)";
            $insertLogStmt = mysqli_prepare($conn, $insertLogQuery);
            mysqli_stmt_bind_param($insertLogStmt, 'ssss', $qr_string, $date, $time_in, $current_time);

            if (mysqli_stmt_execute($insertLogStmt)) {
                echo json_encode([
                    "success" => true,
                    "message" => "Time-Out successful.",
                    "date" => $date,
                    "time_in" => $time_in,
                    "time_out" => $current_time
                ]);
            } else {
                echo json_encode(["success" => false, "message" => "Failed to log data in time_logs."]);
            }
        } else {
            echo json_encode(["success" => false, "message" => "Failed to update Time-Out."]);
        }
    } else {
        // If no pending Time-In, perform Time-In
        $insertQuery = "INSERT INTO time_in (date, time_in, status, qr_string) VALUES (?, ?, 'Pending',?)";
        $insertStmt = mysqli_prepare($conn, $insertQuery);
        mysqli_stmt_bind_param($insertStmt, 'sss', $qr_string, $current_date, $current_time);

        if (mysqli_stmt_execute($insertStmt)) {
            echo json_encode([
                "success" => true,
                "message" => "Time-In successful.",
                "date" => $current_date,
                "time_in" => $current_time
            ]);
        } else {
            echo json_encode(["success" => false, "message" => "Failed to insert Time-In."]);
        }
    }
} else {
    echo json_encode(["success" => false, "message" => "Invalid request."]);
}
?>
