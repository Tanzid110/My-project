
<?php 
    session_start();
    if(!isset($_COOKIE['status'])){
        header('location: login.php?err=invalid');
    }

?>


<html>
    <head>
        <title>post</title>
    </head>
    <body>
            <table border="1" align="center" >
              <tr>
                   
                    <td><img src="Tourism.png" width="150" height="100" alt=""></td>
                    <td  colspan="2"><h1 text align="center">WELCOME TO TOURISM</h1>
                    <hr>
                        <ul align="center">
                        
                        <a href="home.php">HOME</a>

                        <a href="blog.php">BLOG</a>
                   
                        <a href="profile.php">PROFILE</a>
                    
                        <a href="logout.php">LOGOUT</a>
                
                        </ul>
                    </td>
                </tr>
                <tr>
                    <th>TOUR RUNNING</th>
                    <th> CREAT HERE</th>
                </tr>
                <tr>
                   <td><!DOCTYPE html>
<html lang="en">
<head>
 
    <title>Home</title>
</head>
<body>

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


                    <td>
                    <html>
                  
                  <head>
                      <title>File Upload</title>
                  </head>
                  <body>
                          <form method="POST" action="creatpostData.php" enctype="multipart/form-data" >
                             <fieldset>
                              <legend align="center"><h3>CREATE YOUR POST</h3></legend>
                              <table >
                              <table align="center">
                              <tr>
                                  <td>Place</td>
                                  <td><input type="text" name="place" value=""/></td>
                              </tr>
                              <tr>
                                  <td>Text</td>
                                  <td><textarea type="text" name="text" value=""></textarea></td>
                              </tr>
                              <tr>
                                  <td>Date</td>
                                  <td> <input type="date" name="date" value=""/></td>
                              </tr>
                              <tr>
                                  <td>Image</td>
                                  <td> <input type="file" name="myfile" value="" /></td>
                              </tr>
                                  <td><input type="submit" name="submit" value="Submit"/></td>
                              </table>
                             </fieldset>
                          </form>
                  </body>
                  
                  </html>
                  </body>
</html></td>






























