
<?php 

//print_r($_FILES);
session_start();
$src = $_FILES ['myfile']['tmp_name'];
$des ="posts/".$_FILES['myfile']['name'];
$place = $_POST['place'];
$date = $_POST['date'];
$text = $_POST['text'];
$name = $_SESSION['login_user']['username'];
$new_post = $place."|".$text."|".$date."|".$name."\r\n";
$file = fopen('newposts.txt', 'a');
fwrite($file, $new_post);
if(move_uploaded_file($src, $des)){
    header('location:home.php');
}else{
    echo "Error";
}

?>