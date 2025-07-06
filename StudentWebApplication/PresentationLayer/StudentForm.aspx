<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="StudentWebApplication.PresentationLayer.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetStudentByID() {
            var id = document.getElementById("txtStudentId").value;

            // Call the web service method via AJAX
            StudentWebApplication.StudentWebService.GetStudentByID(id, GetStudentByIDSucessCallback, GetStudentByIDErrorCallback);
        }

        function GetStudentByIDSucessCallback(student) {

            if (student != null) {
                document.getElementById("txtID").value = student.ID;
                document.getElementById("txtName").value = student.Name;
                document.getElementById("txtGender").value = student.Gender;
                document.getElementById("txtMarks").value = student.Marks;
                document.getElementById("lblMessage").innerText = "";
            }
            else {
                document.getElementById("txtID").value = "";
                document.getElementById("txtName").value = "";
                document.getElementById("txtGender").value = "";
                document.getElementById("txtMarks").value = "";
                document.getElementById("lblMessage").innerText = "Student not found.";
            }
        }

        function GetStudentByIDErrorCallback(error) {
            alert("Error: " + error.get_message());
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path ="~/PresentationLayer/StudentWebService.asmx" /> 
            </Services>
        </asp:ScriptManager>

        <div style="font-family: Arial; width: 500px;">
            <h2>Student Information</h2>
            <table>
                <tr>
                    <td><b>Enter Student ID:</b></td>
                    <td>
                        <asp:TextBox ID="txtStudentId" runat="server" />
                    </td>
                        <td colspan="2">
                            <input id="btnGetStudent" type="button" value="Get Student" onclick="GetStudentByID();" />
                        </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td><b>ID:</b></td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server" ReadOnly="true" />
                    </td>
                </tr>
                <tr>
                    <td><b>Name:</b></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" ReadOnly="true" />
                    </td>
                </tr>
                <tr>
                    <td><b>Gender:</b></td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server" ReadOnly="true" />
                    </td>
                </tr>
                <tr>
                    <td><b>Marks:</b></td>
                    <td>
                        <asp:TextBox ID="txtMarks" runat="server" ReadOnly="true" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
