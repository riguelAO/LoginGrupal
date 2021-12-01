using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class DeficitCN
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        private int codDeficit;
        private string tipoDeficit;
        private int codEstudiante;

        public int CodDeficit { get => codDeficit; set => codDeficit = value; }
        public string TipoDeficit { get => tipoDeficit; set => tipoDeficit = value; }
        public int CodEstudiante { get => codEstudiante; set => codEstudiante = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarDeficit", codDeficit, tipoDeficit, codEstudiante);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            //traer los datos de la consulta
            DataRow fila = datos.TraerDataRow("spAgregarDeficit", codDeficit, tipoDeficit, codEstudiante);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarDeficit", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarDeficit", codDeficit);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarDeficit");
        }
    }
}
