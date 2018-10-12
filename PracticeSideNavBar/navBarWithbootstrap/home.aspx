<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="navBarWithbootstrap.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron" style="margin-bottom: 0px;">
            <h1>Bootstrap Practise</h1>
            <p>My first practise with boostrap</p>
        </div>
        <nav class="navbar navbar-expand-md navbar-dark bg-info sticky-top">
            <button class="navbar-toggler" data-toggle="collapse" data-target="#target">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="target">
                <a class="navbar-brand">
                    <img src="images/logo_fairy_tail_cles_by_senny67-d5heqy1.png" />
                </a>
                <span class="navbar-text">MyBoostrap</span>
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="home.aspx">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">link1</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Link2</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">link3</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Link4</a>
                    </li>
                </ul>
            </div>
        </nav>
        <img src="images/bootstrap cheat.jpg" class="img-fluid" />
    </form>
</body>
</html>
