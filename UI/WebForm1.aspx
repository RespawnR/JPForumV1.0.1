<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户登录</title>
    <style>
        *{margin: 0;padding: 0}
        html,body{height: 100%} 
        .outer-wrap{
            height: 100%;    
            position: relative;

        }
        .login-panel {
            width: 400px;
            height: 300px;
            border-width: 1px;
            border-style: solid;
            border-color: black;
            position: absolute;
            top: 50%;
            left: 50%;
            margin-top: -150px;
            margin-left: -200px;
        }
        .login-in{
            width:300px;
            height:400px;
            position: absolute;
            top: 50%;
            left:50%;
            margin-left:-120px;
            margin-top:-75px;
        }
</style>
</head>
    <body>
            <div class="outer-wrap">
                <div class="login-panel">
                <form  class="login-in" id="form1"  runat="server">
                  <div> 
                     &nbsp&nbsp&nbsp&nbsp<h1>Welcome</h1>
                    手机号:<asp:TextBox  ID="username" runat="server"></asp:TextBox>
                    </br>
                    密   码：<asp:TextBox   ID="pwd" runat="server" TextMode="Password"></asp:TextBox>
                    </br>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button id="b1" Text="登陆" runat="server" style="width:175px;" OnClick="b1_Click"/>
                      <br />
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:HyperLink ID="h1" runat="server" NavigateUrl="~/signUp.aspx">注册！</asp:HyperLink>
                  </div>
                </form>
            </div>     
                </div>
    </body>
</html>
