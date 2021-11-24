using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class EstudianteCN
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        private int id;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEstudiante");
        }
    }
}
