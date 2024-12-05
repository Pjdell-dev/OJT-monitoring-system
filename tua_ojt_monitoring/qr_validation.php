<?php
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

include "ojt_connect.php";

header('Content-Type: application/json');

$qr_string = $_POST['qr_string'];
$type = $_POST['type']; // 'time_in' or 'time_out'

if (empty($qr_string) || empty($type)) {
    echo json_encode(["success" => false, "message" => "Invalid input"]);
    exit;
}

$table = $type == 'time_in' ? 'time_in' : 'time_out';
$sql = "SELECT * FROM $table WHERE qr_string = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $qr_string);
$stmt->execute();
$result = $stmt->get_result();

if ($result->num_rows > 0) {
    echo json_encode(["success" => true, "message" => "Valid QR"]);
} else {
    echo json_encode(["success" => false, "message" => "Invalid QR"]);
}

$stmt->close();
?>
