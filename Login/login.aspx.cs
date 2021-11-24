using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;
using Login;


namespace Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string user = Login1.UserName;
            string password = Login1.Password;

            Usuario usuario = new Usuario();
            UsuarioBL usuarioBL = new UsuarioBL();

            usuario._Usuario = user;
            usuario._Contrasena = password;

            bool coderror = usuarioBL.Login(usuario);

            string[] valores = new string[2];

            if (coderror)
            {
                valores[0] = "0";
            }
            else
            {
                valores[0] = "1";
            }
            valores[1] = usuarioBL.Mensaje;

            if (valores[0] == "0" && valores[1] == "administrador")
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(user, false);

            }
            else if (valores[0] == "0" && valores[1] == "docente")
            {
                Login1.FailureText = "Usted es docente, no tiene acceso al sistema";
            }
            else
            {
                Login1.FailureText = valores[1];
            }
        }
    }
}