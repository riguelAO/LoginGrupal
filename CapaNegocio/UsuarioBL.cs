using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class UsuarioBL :Interfaces.IUsuario
    {
        private Datos datos = new DatosSQL();

        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Login(Usuario usuario)
        {
            DataRow fila = datos.TraerDataRow("spLoginUsuario", usuario._Usuario, usuario._Contrasena);
            byte CodError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (CodError == 0)
                return true;
            else return false;
        }
    }
}
