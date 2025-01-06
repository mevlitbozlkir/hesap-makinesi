<?php 
    include("conn.php");
    if(isset($_POST["giris"])){
      $username = $_POST["username"];
      $password = $_POST["password"];
      if($username == "" && $password == ""){
        echo '<div class="alert alert-danger" role="alert">
        Kullanıcı Adı Veya Şifre Yanlış
        </div>';
      }
      else
      {
      if(isset($username) && isset($password)){
          $secim = "SELECT * FROM kullaniciler WHERE kullanici_adi = '$username'";
          $calistir = mysqli_query($conn,"$secim");
           $kayitsayisi = mysqli_num_rows($calistir);
           if($kayitsayisi > 0){
              $ilgilikayit = mysqli_fetch_assoc($calistir);
              $haslisifre = $ilgilikayit["parola"];
              if(password_verify($password,$haslisifre))
              {
                session_start();  
                $_SESSION["username"]=$ilgilikayit["kullanici_adi"];
                $_SESSION["email"]=$ilgilikayit["email"];
                header("location:profile.php");
              }
              else
              {
                echo '<div class="alert alert-danger" role="alert">
            Şifre Yanlış
              </div>';
              }
           }

           else{
            echo '<div class="alert alert-danger" role="alert">
            Kullanıcı Adı Yanlış
            </div>';
           }
      }
    }
  }
    
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<form action="login.php" method="post" class="p-5"> 
<div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Kullanıcı Adı</label>
    <input type="text" class="form-control " id="exampleInputEmail1" name="username">
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Şifre</label>
    <input type="password" class="form-control" id="exampleInputPassword1" name="password">
  </div>
  <button type="submit" class="btn btn-primary" name="giris">Giris</button>
</form>
</body>
</html>