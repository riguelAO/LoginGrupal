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

        private int CodEstudiante;
        private string Apellidos;
        private string Nombres;
        private string grado;
        private string DNI;
        private DateTime fechaNaci;
        private string Direccion;
        private string Genero;
        private int codInstitucion;
        private int codCurso;
        private int codGrado;

        public int CodEstudiante1 { get => CodEstudiante; set => CodEstudiante = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public DateTime FechaNaci { get => fechaNaci; set => fechaNaci = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public int CodInstitucion { get => codInstitucion; set => codInstitucion = value; }
        public int CodCurso { get => codCurso; set => codCurso = value; }
        public int CodGrado { get => codGrado; set => codGrado = value; }


        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarEstudiante", CodEstudiante, grado, Apellidos1, Nombres1, DNI1, FechaNaci,
                Direccion1, Genero1, codInstitucion, CodCurso,CodGrado);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            //traer los datos de la consulta
            DataRow fila = datos.TraerDataRow("spAgregarEstudiante", CodEstudiante, grado, Apellidos1, Nombres1, DNI1, FechaNaci,
                Direccion1, Genero1, codInstitucion, CodCurso, CodGrado);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEstudiante", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarEstudiante", CodEstudiante);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEstudiante");
        }
    }
}
