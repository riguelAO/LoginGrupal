using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;

namespace CapaNegocio.Interfaces
{
    interface IUsuario
    {
        bool Login(Usuario usuario);
    }
}
