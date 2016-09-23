<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudentEntry.aspx.cs" Inherits="DatabaseApp.DeleteStudentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <h1>Delete Entry</h1>
    <title></title>
</head>
<body>
    <asp:Label ID="message" runat="server"></asp:Label>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>ID</td><td><asp:TextBox ID="stud_id" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="delete" runat="server" OnClick="delete_Click" Text="Delete Student Entry" />
    </form>
</body>
</html>
