





<html>
    <head>
        <title>form</title>
        <style>
        </style>
    </head>
    <body>
            <table border="1" align="center" >
                <tr>
                    <td  colspan="2" ><h1 align="center">USER PROFILE</h1></td>
                </tr>
               
                <tr>
                   <td><ul>
                   <li>
                        <a href="EditProfile.php"> <b> <i>EDIT PROFILE</i> </b></a>
                    </li>
                    <li>
                        <a href="logout.php"> <b> <i>LOGOUT</i> </b></a>
                    </li>
                </ul></td>
                    <td align="center">
                    <html>
<head>
  <title>User</title>
</head>
     <body>
        <form method="post" action="ProfileCheck.php" enctype="">
          <fieldset>
            <legend style="text-align: center;"><h1>Welcome</h1></legend>
            <br><br><br>
                <table align="center">
          <tr>
            <td><h2 style="text-transform: uppercase">
    <?php
    session_start();
     echo "Name: ".$_SESSION['login_user']['username']."<br>"; 
      echo "Email: ".$_SESSION['login_user']['email'];?>
    </h2>
            </td>
          </tr>
          <tr>
          </tr>
            </table>
            <br><br><br>      
            </fieldset>
        </form>
    </body>
</html>
</td>
                   
                </tr>
            </table>
    </body>
</html>






























