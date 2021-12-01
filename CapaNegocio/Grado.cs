using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class Grado
    {
        private Datos datos = new DatosSQL();
        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarGrado");
        }
    }
}
