<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <div class="jumbotron">
        <h1>Notepad</h1>
        <p class="lead">For temporary use only</p>
        <textarea id="TextArea1" cols="50" rows="4" runat="server"></textarea>
        <p class="lead">    </p>
        <asp:Button ID="Button1" runat="server" Text="Summit" OnClick="Button1_OnClick"/>
      <p class="lead">    </p>
      <p class="lead">    </p>

    </div>
    
</asp:Content>