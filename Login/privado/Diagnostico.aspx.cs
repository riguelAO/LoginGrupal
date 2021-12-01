using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Login.privado
{
    public partial class Diagnostico : System.Web.UI.Page
    {
        private DiagnosticoCN diagnostico= new DiagnosticoCN();
        private void Listar()
        {
            gvDiagnostico.DataSource = diagnostico.Listar().Tables[0];
            gvDiagnostico.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int codDiagnostico = int.Parse(txtCodDiagnostico.Text.Trim());
            string tipoTratamiento = txtTipoDiagnostico.Text.Trim();
            int codDeficit = int.Parse(txtCodDeficit1.Text.Trim());

            diagnostico.CodDiagnostico = codDiagnostico; diagnostico.TipoTratamiento= tipoTratamiento;
            diagnostico.CodDeficit= codDeficit;

            if (diagnostico.Agregar() == true)
                Listar();
            Response.Write("<script>alert('" + diagnostico.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodDiagnostico.Text.Trim());
            diagnostico.CodDiagnostico = id;
            if (diagnostico.Eliminar() == true)
                Listar();
            Response.Write("<script>alert('" + diagnostico.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int codDiagnostico = int.Parse(txtCodDiagnostico.Text.Trim());
            string tipoTratamiento = txtTipoDiagnostico.Text.Trim();
            int codDeficit = int.Parse(txtCodDeficit1.Text.Trim());

            diagnostico.CodDiagnostico = codDiagnostico; diagnostico.TipoTratamiento = tipoTratamiento;
            diagnostico.CodDeficit = codDeficit;

            if (diagnostico.Actualizar() == true)
                Listar();
            Response.Write("<script>alert('" + diagnostico.Mensaje + "');</script>");
        }
    }
}