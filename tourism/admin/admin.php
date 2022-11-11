





<html>
    <head>
        <title>form</title>
        <style>
        </style>
    </head>
    <body>
            <table border="1" align="center" >
                <tr>
                    <td  colspan="2" ><h1 align="center">ADMIN PANNEL</h1></td>
                </tr>
               
                <tr>
                   <td><ul>
                   <li>
                        <a href="admin.php"> <b> <i>USERS</i> </b></a>
                    </li>
                    <li>
                        <a href="../logout.php"> <b> <i>LOGOUT</i> </b></a>
                    </li>
                </ul></td>
                    <td align="center">
                    <html>
<head>

</head>
<body>
    <a href="../profile.php">
<?php
echo '<table border="1">';
$file = fopen("../user.txt", "r") or die("Unable to open file!");
while (!feof($file)){   
    $data = fgets($file); 
    
    echo "<tr><td>" . str_replace('|','</td><td>',$data) . '</td></tr>';
}
echo '</table>';
fclose($file);
?>
</a>

</table>
</body>
</html> 
</td>
                   
                </tr>
            </table>
    </body>
</html>















