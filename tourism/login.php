<?php 


    if(isset($_GET['err'])){
        if($_GET['err'] == 'null'){
            echo "ENTER USERNAME/PASSWORD FIRST";
        }

        if($_GET['err'] == 'invalid'){
            echo "USERNAME/PASSWORD NOT FOUND";
        }

        // if($_GET['err'] == 'bad_request'){
        //     echo "INVALID USERNAME/PASSWORD";
        // }
        

    }

?>

<html>
<head>
    <title>Login</title>
</head>
<body>
<h2 align="center"><b><i>WELCOME TO LOGIN</i></b></h2>

        <form method="post" action="loginCheck.php" enctype="">
            <fieldset>
                <legend align ="center"><h1>LOGIN</h1></legend>
         <table align="center">
                <tr>
                    <td>Username</td>
                    <td>
                    <input type="text" name="username" value=""/>
                    </td>
                </tr> 
                <br>
                <tr>
                    <td>Password</td>
                    <td>
                    <input type="password" name="password" value=""/> 
                    </td>
                </tr>
                <br>
                <tr>
                    <td><input type="submit" name="btn" value="Submit"/></td>
                    <td><hr><a href="forgetPass.php">fortget Password ?</a></td>
                </tr>
                <tr>
                    <td>
                        <br>
                    <p>Want to register? <a href="signup.php">Sign up</a>.</p>
                    </td>
                </tr>
         </table>
                
            </fieldset>
        </form>
</body>
</html>