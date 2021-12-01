using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class DiagnosticoCN
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        private int codDiagnostico;
        private string tipoTratamiento;
        private int codDeficit;

        public int CodDiagnostico { get => codDiagnostico; set => codDiagnostico = value; }
        public string TipoTratamiento { get => tipoTratamiento; set => tipoTratamiento = value; }
        public int CodDeficit { get => codDeficit; set => codDeficit = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarDiagnostico", codDiagnostico, tipoTratamiento, codDeficit);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            //traer los datos de la consulta
            DataRow fila = datos.TraerDataRow("spAgregarDiagnostico", codDiagnostico, tipoTratamiento, codDeficit);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarDiagnostico", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarDiagnostico", codDiagnostico);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarDiagnostico");
        }
    }
}
