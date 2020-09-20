<%@ Page Title="friendlyGTUSolutions-register" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" EnableEventValidation="false" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<section class="hero-area bg-img bg-overlay-2by5" style="background-image: url(img/bg-img/bg4.jpg);">
<div class="container h-100">
<div class="row h-100 align-items-center">
<div class="col-12">

<div class="hero-content text-center">

<h2>Learning Something New</h2>

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
<h4>Register Here</h4>
    <form action="#" method="post" align="center">
<div class="row">
<div class="col-12 col-lg-6">
<div class="form-group">

 Name:<asp:TextBox ID="txtname" CssClass="form-control" placeholder="Name" runat="server"></asp:TextBox>
Enrollment No:<asp:TextBox ID="txtenroll" CssClass="form-control" placeholder="enrollment no" runat="server"></asp:TextBox>
Email:<asp:TextBox ID="txtemail" CssClass="form-control" runat="server" placeholder="Email Address" ></asp:TextBox>  
Create Password:<asp:TextBox ID="txtpass" CssClass="form-control" placeholder="password" runat="server" TextMode="Password"></asp:TextBox>
    
<br />

<asp:Button ID="Button1" CssClass="btn clever-btn w-100" OnClick="Button1_Click" runat="server" Text="submit"  />
    <asp:Label ID="txtlab" runat="server" Text="label"></asp:Label></div>
<a href="login.aspx"><h3><i>If already register then login from here...</i></h3></a>
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





