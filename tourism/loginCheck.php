<?php
    session_start();
    $username = $_POST['username'];
    $password = $_POST['password'];

    if($username == "" || $password == ""){
        header('location: login.php?err=null');
    }else{
        $file = fopen('user.txt', 'r');
        $status = false;
        while(!feof($file)){
            $data = fgets($file);
            $user = explode("|", $data);
            //print_r($user);
            if(trim($user[0]) == $username && trim($user[1]) == $password){
                $status = true;
                setcookie('status', 'true', time()+3600, '/');
                $login_user = ['username'=> $user[0],  'email'=>$user[2]];
                $_SESSION['login_user'] = $login_user;
                if($user[0] == 'admin'){
                    $su = true;
                }
                
            }
        }
        if($su){
            header('location:admin/admin.php');
        }
        
        else if($status){
            header('location: home.php');
        }else{
            header('location: login.php?err=invalid');
        }

    }
?>