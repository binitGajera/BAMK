<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestData.aspx.cs" Inherits="CacheApp.RequestData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label ID="lb1" runat="server" /></td>
            </tr>
            <tr>
                <td>ID:</td><td><asp:TextBox ID="tb1" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="b1" Text="submit" runat="server" OnClick="Button_click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
