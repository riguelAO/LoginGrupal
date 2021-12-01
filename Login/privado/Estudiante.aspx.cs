using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Login.privado
{
    public partial class Estudiante : System.Web.UI.Page
    {
        private EstudianteCN estudiante = new EstudianteCN();
        private void Listar()
        {
            gvEstudiante.DataSource = estudiante.Listar().Tables[0];
            gvEstudiante.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int CodEstudiante = int.Parse(txtCodEstudiante.Text.Trim());
            string grado = txtGrado.Text.Trim();
            string Apellidos = txtApellidos.Text.Trim();
            string Nombres = txtNombres.Text.Trim();
            string DNI = txtDNI.Text.Trim();
            DateTime fechaNaci = Convert.ToDateTime(txtFech.Text);
            string Direccion = txtDireccion.Text.Trim();
            string Genero = txtGenero.Text.Trim();
            int codInstitucion = int.Parse(txtcodInstitucion.Text.Trim());
            int codCurso = int.Parse(txtcodCurso.Text.Trim());
            int codGrado = int.Parse(txtcodGrado.Text.Trim());

            estudiante.CodEstudiante1 = CodEstudiante; estudiante.Grado = grado; estudiante.Apellidos1 = Apellidos;
            estudiante.Nombres1 = Nombres; estudiante.DNI1 = DNI; estudiante.FechaNaci = fechaNaci; estudiante.Direccion1 = Direccion;
            estudiante.Genero1 = Genero; estudiante.CodInstitucion = codInstitucion; estudiante.CodCurso = codCurso;
            estudiante.CodGrado = codGrado;

            if (estudiante.Agregar() == true)
                Listar();
            Response.Write("<script>alert('" + estudiante.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodEstudiante.Text.Trim());
            estudiante.CodEstudiante1 = id;
            if (estudiante.Eliminar() == true)
                Listar();
            Response.Write("<script>alert('" + estudiante.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int CodEstudiante = int.Parse(txtCodEstudiante.Text.Trim());
            string grado = txtGrado.Text.Trim();
            string Apellidos = txtApellidos.Text.Trim();
            string Nombres = txtNombres.Text.Trim();
            string DNI = txtDNI.Text.Trim();
            DateTime fechaNaci = Convert.ToDateTime(txtFech.Text);
            string Direccion = txtDireccion.Text.Trim();
            string Genero = txtGenero.Text.Trim();
            int codInstitucion = int.Parse(txtcodInstitucion.Text.Trim());
            int codCurso = int.Parse(txtcodCurso.Text.Trim());
            int codGrado = int.Parse(txtcodGrado.Text.Trim());

            estudiante.CodEstudiante1 = CodEstudiante; estudiante.Grado = grado; estudiante.Apellidos1 = Apellidos;
            estudiante.Nombres1 = Nombres; estudiante.DNI1 = DNI; estudiante.FechaNaci = fechaNaci; estudiante.Direccion1 = Direccion;
            estudiante.Genero1 = Genero; estudiante.CodInstitucion = codInstitucion; estudiante.CodCurso = codCurso;
            estudiante.CodGrado = codGrado;

            if (estudiante.Actualizar() == true)
                Listar();
            Response.Write("<script>alert('" + estudiante.Mensaje + "');</script>");
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvEstudiante.DataSource = estudiante.Buscar(texto, criterio).Tables[0];
            gvEstudiante.DataBind();
        }

        protected void ddlCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}