using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class DocenteCN
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        private int CodDocente;
        private string Apellidos;
        private string Nombres;
        private string DNI;
        private string correo;
        private string celular;
        private DateTime FechaNac;
        private string Direccion;
        private string Genero;
        private int codInstitucion;
        private int codAdmin;

        public int CodDocente1 { get => CodDocente; set => CodDocente = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Celular { get => celular; set => celular = value; }
        public DateTime FechaNac1 { get => FechaNac; set => FechaNac = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public int CodInstitucion { get => codInstitucion; set => codInstitucion = value; }
        public int CodAdmin { get => codAdmin; set => codAdmin = value; }


        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarDocente", CodDocente, Apellidos, Nombres, DNI, correo,
                celular, FechaNac, Direccion, Genero, codInstitucion, codAdmin);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            //traer los datos de la consulta
            DataRow fila = datos.TraerDataRow("spAgregarDocente", CodDocente, Apellidos, Nombres, DNI, correo,
                celular, FechaNac, Direccion, Genero, codInstitucion, codAdmin);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarDocente", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarDocente", CodDocente);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarDocente");
        }
    }
}
