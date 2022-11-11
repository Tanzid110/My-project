<?php 
	session_start();

	$username = $_POST['username'];
	$password = $_POST['password'];

	if($username == null || $password == null){
		echo "null email/password";
	}else{
		$file = fopen('user.txt', 'r');
		
		while (!feof($file)) {
			$data=fgets($file);
			$user = explode('|', $data);
			if($username == trim($user[0]) && $password == trim($user[1])){
				$_SESSION['status'] = true;
				setcookie('status', 'true', time()+3600, '/');
                $status=true;
				header('location: login.php');
			}
		}
		echo "invalid user";
	}

?>