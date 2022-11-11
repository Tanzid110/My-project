<html>
<head>
    <title>Chnage Password</title>
</head>
<body>

        <form method="post" action="forgetCheck.php" enctype="">
            <fieldset>
                <legend align="center"><h2>CHANGE PASSWORD</h2></legend>
              <table align="center">
              <tr>
                <td>Username</td>
                <td><input type="text" name="username" value=""/> </td>
              </tr>
                <tr>
                    <td>New Password</td>
                    <td><input type="password" name="password" value=""/></td>
                </tr>
                <tr>
                    <td>Retype Password</td>
                    <td> <input type="password" name="repassword" value=""/></td>
                </tr>   
                <td><hr><input type="submit" name="btn" value="Submit"/></td>
              </table>
                
            </fieldset>
        </form>
</body>
</html>