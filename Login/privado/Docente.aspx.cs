using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Login.privado
{
    public partial class Docente : System.Web.UI.Page
    {
        private DocenteCN docente = new DocenteCN();
        private void Listar()
        {
            gvDocente.DataSource = docente.Listar().Tables[0];
            gvDocente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int CodDocente = int.Parse(txtCodDocente.Text.Trim());
            string Apellidos = txtApellidos.Text.Trim();
            string Nombres = txtNombres.Text.Trim();
            string DNI = txtDNI.Text.Trim();
            string Correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            DateTime fechaNaci = Convert.ToDateTime(fechaNac.Text);
            string Direccion = txtDireccion.Text.Trim();
            string Genero = txtCorreo.Text.Trim();
            int codInstitucion = int.Parse(txtCodInstitucion.Text.Trim());
            int codAdmin = int.Parse(txtCodAdmin.Text.Trim());

            docente.CodDocente1 = CodDocente; docente.Apellidos1 = Apellidos; docente.Nombres1 = Nombres; docente.DNI1 = DNI;
            docente.Correo = Correo; docente.Celular = celular; docente.FechaNac1 = fechaNaci; docente.Direccion1 = Direccion;
            docente.Genero1 = Genero; docente.CodInstitucion = codInstitucion; docente.CodAdmin = codAdmin;
            if (docente.Agregar() == true)
                Listar();
            Response.Write("<script>alert('" + docente.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodDocente.Text.Trim());
            docente.CodDocente1 = id;
            if (docente.Eliminar() == true)
                Listar();
            Response.Write("<script>alert('" + docente.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int CodDocente = int.Parse(txtCodDocente.Text.Trim());
            string Apellidos = txtApellidos.Text.Trim();
            string Nombres = txtNombres.Text.Trim();
            string DNI = txtDNI.Text.Trim();
            string Correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            DateTime fechaNaci = Convert.ToDateTime(fechaNac.Text);
            string Direccion = txtDireccion.Text.Trim();
            string Genero = txtCorreo.Text.Trim();
            int codInstitucion = int.Parse(txtCodInstitucion.Text.Trim());
            int codAdmin = int.Parse(txtCodAdmin.Text.Trim());

            docente.CodDocente1 = CodDocente; docente.Apellidos1 = Apellidos; docente.Nombres1 = Nombres; docente.DNI1 = DNI;
            docente.Correo = Correo; docente.Celular = celular; docente.FechaNac1 = fechaNaci; docente.Direccion1 = Direccion;
            docente.Genero1 = Genero; docente.CodInstitucion = codInstitucion; docente.CodAdmin = codAdmin;

            if (docente.Actualizar() == true)
                Listar();
            Response.Write("<script>alert('" + docente.Mensaje + "');</script>");
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvDocente.DataSource = docente.Buscar(texto, criterio).Tables[0];
            gvDocente.DataBind();
        }
        protected void ddlCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}