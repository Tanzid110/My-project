
<?php 
    session_start();
    if(!isset($_COOKIE['status'])){
        header('location: login.php?err=invalid');
    }

?>



<html>
    <head>
        <title>home</title>
    </head>
    <body>
            <table border="1" align="center" >
              <tr>
                   
                    <td><img src="Tourism.png" width="150" height="100" alt=""></td>
                    <td  colspan="2"><h1 text align="center">WELCOME TO TOURISM</h1>
                    <hr>
                        <ul align="center">
                        
                        <a href="home.php">HOME</a>

                        <a href="Blog/blog.php">BLOG</a>
                   
                        <a href="profile.php" style="text-transform: uppercase"><?php echo $_SESSION['login_user']['username'];?></a>
                   
                    
                        <a href="logout.php">LOGOUT</a>
                
                        </ul>
                    </td>
                </tr>
                <tr>
                    <th>TOUR RUNNING</th>
                    <th> <a href="createPost.php"> CREATE A POST</a></th>
                    <th> <a href="createTour.php"> TOUR PLANNING </a></th>
                </tr>
                <tr>
                   <td>




    <!-- <a href="createPost.php">Create New Post</a> -->
   <h5>
   <?php
   
   $file = fopen('newtour.txt', 'r');
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
       
   }


?>


</h5>


<?php


?>
</body>
</html></td>
                    <td><!DOCTYPE html>
<html lang="en">
<head>
 
    <title>Home</title>
</head>
<body>

    <!-- <a href="createPost.php">Create New Post</a> -->
   <h5 >
   <?php
   
   $file = fopen('newposts.txt', 'r');
   $status = false;
   while(!feof($file)){
       $data = fgets($file);
       $post = explode("|", $data);
        foreach($post as $value)
        {
            // for($i=0;$i<(count($value));$i++){
            //      echo $i;  
            // }
            echo $value."<br>"."<hr>";
            // $files = glob("upload/*.*");

            // for ($i=0; $i<count($files); $i++) {
            // $image = $files[$i];
            
            // echo '<img src="'.$image .'" width="100" height="100" alt="Random image" />'."<br /><br />";
            // }
        }
       
   }


?>


</h5>


<?php


?></td>
                   <td><a href=""></a></td>
                </tr>
            </table>
    </body>
</html>