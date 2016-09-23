<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDetails.aspx.cs" Inherits="DatabaseApp.UpdateDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <h1>Update Marks</h1>
    <title>Update Marks</title>
</head>
<body>
    <asp:Label ID="message" runat="server" Text=""></asp:Label>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>ID:</td><td><asp:TextBox ID="stud_id" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Marks:</td><td><asp:TextBox ID="stud_marks" runat="server"></asp:TextBox></td>
            </tr>
         </table>
        <asp:Button ID="update_button" runat="server" OnClick="update_button_Click" Text="Update" />
    </form>
</body>
</html>
