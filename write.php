<?php
require("config/config.php");
require("lib/db.php");
$conn=db_init($config["host"],$config["duser"],$config["dpw"],$config["dname"]);
	$result = mysqli_query($conn,'SELECT*FROM topic');
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
	<link rel="stylesheet" type="text/css" href="http://localhost:8080/style.css">
	<!-- Bootstrap -->
	    <link href="http://localhost:8080/bootstrap-3.3.4-dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body id = "target">
	<div class="container">

		<header class = "jumbotron text-center">
			<img src="https://s3-ap-northeast-1.amazonaws.com/opentutorialsfile/course/94.png" alt="생활코딩" class="img-circle" id="logo">
			<h1><a href="http://localhost:8080/index.php">JavaScript</a></h1>
		</header>
		<div class="row">
			<nav class = "col-md-3">
				<ol class="nav nav-pills nav-stacked">
					<?php
					while($row=mysqli_fetch_assoc($result))
					{
						echo '<li><a href="http://localhost:8080/index.php?id='.$row['id'].'">'.htmlspecialchars($row['title']).'</a></li>'."\n";
					}
					?>
				</ol>
			</nav>
			<div class="col-md-9">

				<form action="process.php" method="post">
					<div class="form-group">
				    <label for="form-title">Title</label>
				    <input type="text" class="form-control" name="title" id="form-title" placeholder="Enter the title.">
				  </div>
					<div class="form-group">
				    <label for="form-author">Author</label>
				    <input type="text" class="form-control" name="title" id="form-author" placeholder="Enter the author.">
				  </div>

					<div class="form-group">
						<label for="form-description">Description</label>
						<textarea name="description" class="form-control" rows="10" id="form-description" placeholder="Enter the description."></textarea></p>
					</div>

					<input type="submit" name="name" class="btn btn-default btn-lg" />
				</form>

				<hr>
				<div id = "control">
					<div class="btn-group" role="group" aria-label="...">
						<input type="button" value = "white" id = "white_btn" class="btn btn-default btn-lg" />
						<input type="button" value = "black" id = "black_btn" class="btn btn-default btn-lg" />
					</div>
				<a href="http://localhost:8080/write.php"  class="btn btn-success btn-lg">Write</a>
				</div>

			</div>

		</div>
		<script src = "http://localhost:8080/script.js"></script>
		<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
		    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
		    <!-- Include all compiled plugins (below), or include individual files as needed -->
		    <script src="http://localhost:8080/bootstrap-3.3.4-dist/js/bootstrap.min.js"></script>

	</div>
</body>
</html>
