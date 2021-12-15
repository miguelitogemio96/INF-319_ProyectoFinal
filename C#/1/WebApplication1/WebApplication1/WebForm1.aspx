<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Ingrese la lista en formato 1 2,3 4,5 6,7 8"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Width="323px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CALCULAR" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="RESULTADO:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="318px"></asp:TextBox>
    </form>
</body>
</html>
