<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="estructuraCapas.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        *{
            text-align: center;
            margin: 0;
            padding: 0;
        }

        .container{
            width:100vw;
            display:flex;
            height:100vh;
            justify-content:center;
            align-items: center;
            background-color:mediumaquamarine;
            color:black;
        }
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            width: 98%;
        }
        .auto-style23 {
            height: 23px;
            width: 97px;
        }
        .auto-style24 {
            width: 97px;
        }
        .auto-style26 {
            height: 20px;
            width: 97px;
        }
        .auto-style31 {
            height: 23px;
            width: 168px;
        }
        .auto-style32 {
            width: 168px;
        }
        .auto-style33 {
            width: 168px;
            height: 26px;
        }
        .auto-style34 {
            width: 168px;
            height: 22px;
        }
        .auto-style35 {
            height: 20px;
            width: 168px;
        }
        .auto-style43 {
            height: 23px;
        }
        .auto-style44 {
            height: 23px;
            width: 127px;
        }
        .auto-style45 {
            width: 127px;
            height: 22px;
        }
        .auto-style46 {
            width: 127px;
            height: 26px;
        }
        .auto-style47 {
            width: 127px;
        }
        .auto-style48 {
            height: 20px;
            width: 127px;
        }
        .auto-style50 {
            height: 26px;
        }
        .auto-style51 {
            height: 22px;
        }
    </style>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td class="auto-style43" colspan="3">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF9933" Text="REGISTRO"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="3">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF9933" Text="ALUMNO:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:Label ID="lblcodigoalumno" runat="server" Text="Codigo alumno:" BorderStyle="None"></asp:Label>
                    </td>
                    <td class="auto-style44">
                        <asp:TextBox ID="txtcodigoalumno" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style24" rowspan="3">
                        <asp:Label ID="lblmensajealumno" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34">
                        <asp:Label ID="lblnombre" runat="server" Text="Nombre estudiante:"></asp:Label>
                    </td>
                    <td class="auto-style45">
                        <asp:TextBox ID="txtnombrealumno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        <asp:Label ID="lblespecialidad" runat="server" Text="Especialidad:"></asp:Label>
                    </td>
                    <td class="auto-style46">
                        <asp:TextBox ID="txtespecialidad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="3">
                        <asp:Button ID="btnguardaralumno" runat="server" OnClick="btnguardaralumno_Click" Text="Agregar alumno" Width="124px" BackColor="#FF9933" BorderWidth="2px" />
                        <asp:Button ID="btnconsultaralumno" runat="server" Text="Consultar alumno" Width="116px" OnClick="btnconsultaralumno_Click" BackColor="#FF9933" BorderWidth="2px" />
                        <asp:Button ID="btneliminaralumno" runat="server" Text="Borrar alumno" Width="128px" OnClick="btneliminaralumno_Click" BackColor="#FF9933" BorderWidth="2px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31"></td>
                    <td class="auto-style44">&nbsp;</td>
                    <td class="auto-style23"></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF9933" Text="CURSO:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34">
                        <asp:Label ID="lblcodigocurso" runat="server" Text="Codigo curso:"></asp:Label>
                    </td>
                    <td class="auto-style45">
                        <asp:TextBox ID="txtcodigocurso" runat="server" Height="16px"></asp:TextBox>
                    </td>
                    <td class="auto-style24" rowspan="3">
                        <asp:Label ID="lblmensajecurso" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34">
                        <asp:Label ID="lblnombrecurso" runat="server" Text="Nombre curso:"></asp:Label>
                    </td>
                    <td class="auto-style45">
                        <asp:TextBox ID="txtnombrecurso" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34">
                        <asp:Label ID="lblcurso" runat="server" Text="Curso"></asp:Label>
                    </td>
                    <td class="auto-style45">
                        <asp:TextBox ID="txtcurso" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="3">
                        <asp:Button ID="btnagregarcurso" runat="server" OnClick="btnagregarcurso_Click" Text="Agregar curso" Width="128px" BackColor="#FF9933" BorderWidth="2px" />
                        <asp:Button ID="btnconsultarcurso" runat="server" Text="Consultar curso" Width="126px" OnClick="btnconsultarcurso_Click" BackColor="#FF9933" BorderWidth="2px" />
                        <asp:Button ID="btneliminarcurso" runat="server" Text="Borrar curso" Width="134px" OnClick="btneliminarcurso_Click" BackColor="#FF9933" BorderWidth="2px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style35"></td>
                    <td class="auto-style48"></td>
                    <td class="auto-style26"></td>
                </tr>
                <tr>
                    <td class="auto-style51" colspan="3">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF9933" Text="DOCENTE:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style32">
                        <asp:Label ID="lblceduladocente" runat="server" Text="Cedula docente:"></asp:Label>
                    </td>
                    <td class="auto-style47">
                        <asp:TextBox ID="txtceduladocente" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style24" rowspan="3">
                        <asp:Label ID="lblmensajedocente" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:Label ID="lblnombredocente" runat="server" Text="Nombre docente:"></asp:Label>
                    </td>
                    <td class="auto-style44">
                        <asp:TextBox ID="txtnombredocente" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style32">
                        <asp:Label ID="lbloficina" runat="server" Text="Oficina"></asp:Label>
                    </td>
                    <td class="auto-style47">
                        <asp:TextBox ID="txtoficina" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style50" colspan="3">
                        <asp:Button ID="btnagregardocente" runat="server" OnClick="btnagregardocente_Click" Text="Agregar docente" Width="128px" BackColor="#FF9933" BorderWidth="2px" />
                        <asp:Button ID="Button5" runat="server" Text="Consultar docente" Width="133px" OnClick="Button5_Click" BackColor="#FF9933" BorderWidth="2px" />
                        <asp:Button ID="btneliminardocente" runat="server" Text="Borrar docente" Width="143px" OnClick="btneliminardocente_Click" BackColor="#FF9933" BorderWidth="2px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style32">
                        &nbsp;</td>
                    <td class="auto-style47">
                        &nbsp;</td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    </div>
    
</body>
</html>
