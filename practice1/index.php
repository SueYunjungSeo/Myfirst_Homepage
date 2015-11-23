<?php
$conn=mysqli_connect("localhost", "root", "seo1521", "mytest");
mysqli_select_db($conn, "mytest");
$result = mysqli_query($conn,'SELECT*FROM topic');
while($row=mysqli_fetch_assoc($result))
  echo '<a href="index.php?id='.$row['id'].'">'.htmlspecialchars($row['title']).'</a><br />';

  $sql = 'SELECT topic.id,title,name,description,created FROM topic LEFT JOIN user ON topic.author=user.id WHERE topic.id='.$_GET['id'];
  $result = mysqli_query($conn, $sql);
  $row = mysqli_fetch_assoc($result);
  echo htmlspecialchars($row['title']).'<br />';
  echo htmlspecialchars($row['name']).'<br />';
  echo $row['description'].'<br />';
  echo $row['created'].'<br />';

 ?>
