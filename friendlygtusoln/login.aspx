<%@ Page Title="friendlyGTUSolutions-login" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="hero-area bg-img bg-overlay-2by5" style="background-image: url(img/bg-img/p1.jpg);">
<div class="container h-100">
<div class="row h-100 align-items-center">
<div class="col-12">

<div class="hero-content text-center">

<h2>Lets Enter Into It</h2>

</div>
</div>
</div>
</div>
</section>

    <div class="register-contact-form mb-100 wow fadeInUp" data-wow-delay="250ms">
<div class="container-fluid">
<div class="row">
<div class="col-12">
<div class="forms">
<h4>login from here</h4>
    <form action="#" method="post" align="center">
<div class="row">
<div class="col-12 col-lg-6">
<div class="form-group">
Name: <asp:TextBox ID="TextBox1" CssClass="form-control"  placeholder="Name" runat="server"></asp:TextBox>
Password:<asp:TextBox ID="TextBox2" CssClass="form-control"  placeholder="password" TextMode="Password" runat="server"></asp:TextBox>
<br />

    <asp:Button ID="Button1" runat="server" Text="login" CssClass="btn clever-btn w-100" OnClick="Button1_Click" />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</div>
</div>




</div>
</form>
</div>
</div>
</div>
</div>
</div>
</asp:Content>



