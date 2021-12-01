using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Login.privado
{
    public partial class Deficit : System.Web.UI.Page
    {
        private DeficitCN deficit = new DeficitCN();
        private void Listar()
        {
            gvDeficit.DataSource = deficit.Listar().Tables[0];
            gvDeficit.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int codDeficit = int.Parse(txtCodDeficit.Text.Trim());
            string tipoDeficit = txtTipoDeficit.Text.Trim();
            int codEstudiante = int.Parse(txtCodEstudiante.Text.Trim());

            deficit.CodDeficit = codDeficit; deficit.TipoDeficit = tipoDeficit; deficit.CodEstudiante = codEstudiante;

            if (deficit.Agregar() == true)
                Listar();
            Response.Write("<script>alert('" + deficit.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodDeficit.Text.Trim());
            deficit.CodDeficit = id;
            if (deficit.Eliminar() == true)
                Listar();
            Response.Write("<script>alert('" + deficit.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int codDeficit = int.Parse(txtCodDeficit.Text.Trim());
            string tipoDeficit = txtTipoDeficit.Text.Trim();
            int codEstudiante = int.Parse(txtCodEstudiante.Text.Trim());

            deficit.CodDeficit = codDeficit; deficit.TipoDeficit = tipoDeficit; deficit.CodEstudiante = codEstudiante;

            if (deficit.Actualizar() == true)
                Listar();
            Response.Write("<script>alert('" + deficit.Mensaje + "');</script>");
        }


    }
}