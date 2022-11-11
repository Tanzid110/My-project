<?php 

    if(isset($_GET['err'])){
        if($_GET['err'] == 'null'){
            echo "PLEASE INSERT SOME DATA FIRST";
        }

        // if($_GET['err'] == 'invalid'){
        //     echo "username/password not found ...";
        // }

        // if($_GET['err'] == 'bad_request'){
        //     echo "please login first ...";
        // }
    }

?>


<html>
<head>
    <title>signup</title>
</head>
<body>
    <form method="post" action="signupCheck.php" enctype="">
        <fieldset>
            <legend align= "center"><h2>SIGNUP</h2></legend>
            <table align= "center">
            <h1 align= "center">REGISTRATION</h1>
                   <p align= "center"><b>Please fill in this form to create an account.</b></p>
                      <hr>
                <tr>
                    <td>USERNAME</td>
                    <td><input type="text" name="username" value="" placeholder="username" /></td>
                </tr>
                <tr>
                    <td>EMAIL</td>
                    <td><input type="email" name="email" value="" placeholder="email" /></td>
                </tr>

                <tr>
                    <td>PASSWORD</td>
                    <td><input type="password" name="password" value="" placeholder="password" /></td>
                </tr>
                <tr>
                    <td>PHONE</td>
                    <td><input type="number" name="number" value="" placeholder="number" /></td>
                </tr>
                <tr>
                    <td>DATE OF BIRTH</td>
                    <td><input type="date" name="dob" value="" /></td>
                </tr>
                <tr>
                    <td>GENDER</td>
                    <td>
                        <input type="radio" name="gender" value=""/> Male 
                        <input type="radio" name="gender" value=""/> Female 
                        <input type="radio" name="gender" value=""/> Other
                    </td>
                </tr>
                <tr>
                    <td>PHOTO</td>
                    <td><input type="file" name="photo" value="" ></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" name="" value="Submit"/>
                        <input type="reset" name="" value="Reset"/>
                    </td>
                </tr>
                <tr>
                    <td><hr><p>want to sign in? <a href="login.php">Sign in</a>.</p></td>
                </tr>
            </table>
        </fieldset>
    </form>
</body>
</html>