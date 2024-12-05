<?php
$file = 'uploads/test.txt';
$content = 'Testing write permissions!';
if (file_put_contents($file, $content)) {
    echo "File created successfully!";
} else {
    echo "Failed to write to file.";
}
?>
