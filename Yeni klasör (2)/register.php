<?php 
    include("conn.php");
        
    if(isset($_POST["submit"]))
    {
       
        $username = $_POST["username"];
        $password = password_hash($_POST["password"], PASSWORD_DEFAULT);
        $email = $_POST["email"];
      
        $ekle = "INSERT INTO kullaniciler (kullanici_adi , email, parola ) VALUES ('$username' , '$email' , '$password')";
        $calistirekle = mysqli_query($conn , $ekle);
        if($calistirekle)
        {
          echo '<div class="alert alert-success" role="alert">
            Kayıt Başarılı Bir Şekilde Eklendi
          </div>';
        }
        else  
        {
          echo '<div class="alert alert-danger" role="alert">
            Kayıt Eklenirken Bir Hata Oluştu
              </div>';
        }
       mysqli_close($conn);
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
<form action="register.php" method="post" class="p-5"> 
<div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Kullanıcı Adı</label>
    <input type="text" class="form-control " id="exampleInputEmail1" name="username">
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Mail Adresi</label>
    <input type="email" class="form-control" id="exampleInputEmail1" name="email" aria-describedby="emailHelp">
    
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Şifre</label>
    <input type="password" class="form-control" id="exampleInputPassword1" name="password">
  </div>
  <button type="submit" class="btn btn-primary" name="submit">Submit</button>
</form>
</body>
</html>