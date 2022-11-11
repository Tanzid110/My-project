<?php
    session_start();
    $username = $_POST['username'];
    $email = $_POST['email'];
   

    if($username == ""){
        header('location: EditProfile.php?err=null');
    }else{

        $file = fopen('user.txt','r');
        while(!feof($file)){
            $data = fgets($file);
            $user = explode("|",$data);

            if(trim($user[0] == $username)){
                $old = $user[0];
                $final = str_replace($old,$email,$data);
                file_put_contents('user.txt',$final);

                header('location: login.php');
                break;

            }
            
            
        }






    }
?>