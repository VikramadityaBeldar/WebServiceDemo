<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorPage.aspx.cs" Inherits="CalculatorWebApplication.CalculatorPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="font-family:Arial">

            <!-- Dropdown to choose operation -->
            <tr>
                <td><b>Select Operation</b></td>
                <td>
                    <asp:DropDownList ID="ddlOperation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlOperation_SelectedIndexChanged">
                        <asp:ListItem Text="Add 2 Numbers" Value="2" />
                        <asp:ListItem Text="Add 3 Numbers" Value="3" />
                    </asp:DropDownList>
                </td>
            </tr>

            <!-- Panel for 2 numbers -->
            <asp:Panel ID="panelAdd2" runat="server">
                <tr>
                    <td><b>First Number</b></td>
                    <td><asp:TextBox ID="firstNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Second Number</b></td>
                    <td><asp:TextBox ID="secondNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAdd" runat="server" Text="Add 2 Numbers" OnClick="btnAdd_Click" />
                    </td>
                </tr>
            </asp:Panel>

            <!-- Panel for 3 numbers -->
            <asp:Panel ID="panelAdd3" runat="server" Visible="false">
                <tr>
                    <td><b>First Number</b></td>
                    <td><asp:TextBox ID="txtFirst3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Second Number</b></td>
                    <td><asp:TextBox ID="txtSecond3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Third Number</b></td>
                    <td><asp:TextBox ID="txtThird3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAdd3" runat="server" Text="Add 3 Numbers" OnClick="btnAdd3_Click" />
                    </td>
                </tr>
            </asp:Panel>

            <!-- Result Display -->
            <tr>
                <td><b>Result</b></td>
                <td><asp:Label ID="lblResult" runat="server"></asp:Label></td>
            </tr>

            <!-- Recent Transactions -->
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvTransactions" runat="server">
                        <%--<Columns>
                            <asp:BoundField DataField="." HeaderText="Recent Calculations" />
                        </Columns>--%>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
