<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StrengthWeakness.aspx.cs" Inherits="Pokemon.StrengthWeakness" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblAttackType" Text="Attack Type:"></asp:Label>
        <asp:DropDownList runat="server" ID="ddlAttackType"></asp:DropDownList>
        <br /><br />
        <asp:Label runat="server" ID="lblDefenseTypes" Text="Defense Types:"></asp:Label>
        <asp:DropDownList runat="server" ID="ddlDefenseType1"></asp:DropDownList>
        <asp:DropDownList runat="server" ID="ddlDefenseType2"></asp:DropDownList>
        <br /><br />
        <asp:Button runat="server" ID="btnSubmit" Text="Submit" />&nbsp;
        <asp:Button runat="server" ID="btnReset" Text="Reset" />
        <br /><br />
        <asp:Label runat="server" ID="lblDisplay"></asp:Label>
    </div>
    </form>
</body>
</html>
