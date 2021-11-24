<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Docente.aspx.cs" Inherits="Login.privado.Docente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>CodDocente : <asp:TextBox runat="server" Id="CodDocente" />
            <p>Apellidos : <asp:TextBox runat="server" Id="txtApellidos"/>
            <p>Nombres: <asp:TextBox runat="server" Id="txtNombres"/></p>
            <p>Dni : <asp:TextBox runat="server" Id="DNI"  /></p>
            <p>Correo : <asp:TextBox runat="server" Id="correo"  /></p>
            <p>celular : <asp:TextBox runat="server" Id="txtcelular"  /></p>
            <p>fechaNac: <asp:TextBox runat="server" Id="fechaNac"  /></p>
             <p>Direccion : <asp:TextBox runat="server" Id="txtDireccion" Width="230px" /></p>
             <p>Genero : <asp:TextBox runat="server" Id="txtGenero" /></p>
             <p>codInstitucion: <asp:TextBox runat="server" Id="txtcodInstitucion" /></p>
             <p>codAdmin: <asp:TextBox runat="server" Id="txtcodAdmin" /></p>
             <p>
                <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click" />
                <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click" />
                <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click" />
            </p>
        <p>
                <asp:GridView runat="server" Id="gvCliente" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
