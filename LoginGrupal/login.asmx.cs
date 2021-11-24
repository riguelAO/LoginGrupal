using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaEntidades;

namespace LoginGrupal
{
    /// <summary>
    /// Descripción breve de login
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class login : System.Web.Services.WebService
    {

        [WebMethod(Description ="Login de Usuario")]
        public String[] Login(String _Usuario, string _Contrasena)
        {
            Usuario usuario = new Usuario();
            UsuarioBL usuarioBL = new UsuarioBL();
            usuario._Usuario = _Usuario;
            usuario._Contrasena = _Contrasena;
            bool CodError = usuarioBL.Login(usuario);
            string[] valores = new string[2];
            if (CodError == true) valores[0] = "0";
            else valores[0] = "1";
            valores[1] = usuarioBL.Mensaje;
            return valores;
        }
    }
}
