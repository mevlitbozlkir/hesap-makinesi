<?php 
session_start();
if(isset($_SESSION["username"])){
echo"<h3>".$_SESSION["username"]."  HoşGeldin </h3>";
echo"<h3>".$_SESSION["email"]."</h3>";
echo"<a href='cikis.php' style='background = red; color=#fff'>Çıkış</a>";
}
else{
echo"Bu sayfayı görüntüleme yetkiniz yok";
}
?>