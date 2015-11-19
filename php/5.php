<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8"/>
</head>
<body>
  <?php
  echo htmlspecialchars ('<script>alert(1);</script>
  <a href="http://opentutorials.org/course/1">coding</a>');
   ?>
</body>
</html>
