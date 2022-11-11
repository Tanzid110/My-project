
<?php 
session_start();
//print_r($_FILES);

$name = $_SESSION['login_user']['username'];


$src = $_FILES ['myfile']['tmp_name'];
$des ="image/".$_FILES['myfile']['name'];
$place = $_POST['place'];
$date = $_POST['date'];
$text = $_POST['text'];

$new_post = $place."|".$text."|".$date."|".$name."\r\n";
$file = fopen('blogs.txt', 'a');
fwrite($file, $new_post);
if(move_uploaded_file($src, $des)){
    header('location:../home.php');
}else{
    echo "Error";
}

?>