using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Login.privado
{
    public partial class EstudiantesView : System.Web.UI.Page
    {
        private EstudianteCN estudiante = new EstudianteCN();
        private void Listar()
        {
            gvCliente.DataSource = estudiante.Listar().Tables[0];
            gvCliente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }


    }
}