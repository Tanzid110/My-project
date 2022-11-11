


<html>
    <head>
        <title>form</title>
        <style>
        </style>
    </head>
    <body>
            <table border="1" align="center" >
                <tr>
                    <td  colspan="2"><h1>EDIT PROFILE INFO</h1></td>
                </tr>
                <tr>
                    <th>DASHBORD</th>
                    <th>EDIT HERE</th>
                </tr>
                <tr>
                   <td><ul>
                   <li>
                        <a href="home.php"> <b> <i>HOME</i> </b></a>
                    </li>
                    <li>
                        <a href="profile.php"> <b> <i>PROFILE</i> </b></a>
                    </li>
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
                                 <title>Profile editing</title>
                             </head>

                        <body>
                            <fieldset>
                               <legend align="center"><h3>EDIT PROFILE</h3></legend>
                                  <table align="center">
                                        <form method="post" action="location:editprofileCheck.php" enctype="">
             <tr>
                <td>NAME</td>
                <td>
                <input type="text" name="username" value="<?php session_start(); echo $_SESSION['login_user']['username']; ?>"/>
                </td>
            </tr>

            <tr>
                <td>EMAIL</td>
                <td>
                <input type="email" name="email" value="<?php  echo $_SESSION['login_user']['email']; ?>"/>
                </td>
            </tr>
            <tr>
                <td><input type="submit" name="btn" value="Update" /><br /></td>
            </tr>
              <!-- <?php
            echo $msg;
            ?>   -->
        </form>
       
</table>
   </fieldset>
</body>

</html>
</td>
                   
                </tr>
            </table>
    </body>
</html>
