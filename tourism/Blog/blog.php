<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>blog</title>
</head>
<body>
    <h1>welcome to blog</h1>
    <a href="creatblog.php">Create You own</a>

    <h5>
   <?php
   
   $file = fopen('blogs.txt', 'r');
   $status = false;
   while(!feof($file)){
       $data = fgets($file);
       $post = explode("|", $data);
        foreach($post as $value)
        {
            echo $value."<br>";
            // $files = glob("upload/*.*");

            // for ($i=0; $i<count($files); $i++) {
            // $image = $files[$i];
            
            // echo '<img src="'.$image .'" width="100" height="100" alt="Random image" />'."<br /><br />";
            // }
        }
        echo "<hr>";
       
   }


?>


</h5>


</body>
</html>