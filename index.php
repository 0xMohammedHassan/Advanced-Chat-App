
<html>


<form  method="post" action="index.php">

<label class=".a"> AES-CTR Coded By Mohammed G. Abo Hassan</label>
 <br>PlainText &nbsp;<input type="text"  name="t1"    />
     <input type="submit" value="Encrypt" name="b1" />
	 <br> 

 <br>    CipherText &nbsp;<input type="text"  name="t3"    />
    <input type="submit" value="Decrypt" name="b2" />
<br> <br> 

<?php // Example (of 256-bit AES encryption in CTR mode):

include 'aes.php';
include 'ctr.php';

// See the "README" for information about choosing an appropriate key
$key = 'V<||5DK7KdRYyBLEtY^w~0yk1"#NCZ|N';
$cipher = new CTR(new aes($key));

if(isset($_POST['b1'])){
	

$text = $_POST['t1'];

$code = $cipher->encrypt($text);
$done1 = base64_encode($code);
 echo "
<br>Output &nbsp;<input type=\"text\" name=\"t2\" value= $done1 id=\"t2\"   />
";
}

if(isset($_POST['b2'])){
	$org =$_POST['t3'];
	$done3= base64_decode($org);
	
$text2 = $cipher->decrypt($done3);
//echo "plaintext: $text";
 echo "
<br>Output &nbsp;<input type=\"text\" name=\"t4\" value= $text2 id=\"t4\"   />
";
    }
// The $code variable contains the encrypted raw binary data. You can convert raw binary to a safe ASCII string using base64_encode:
//echo "ciphertext: ", base64_encode($code), "<br>";
//echo "plaintext: $text";
?>

</form>
</html>