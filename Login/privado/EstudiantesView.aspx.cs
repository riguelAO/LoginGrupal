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
        private Curso curso = new Curso();
        private Grado grado = new Grado();
        
        private void Listar()
        {
            gvCliente.DataSource = estudiante.Listar().Tables[0];
            gvCliente.DataBind();
        }
        private void Listar1()
        {
            gvCursos.DataSource = curso.Listar().Tables[0];
            gvCursos.DataBind();
        }
        private void Listar2()
        {
            gvGrados.DataSource = grado.Listar().Tables[0];
            gvGrados.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
                Listar1();
                Listar2();
        }


    }
}