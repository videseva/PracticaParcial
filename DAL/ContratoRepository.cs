using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
namespace DAL
{
    public class ContratoRepository
    {

        private readonly string FileName = "Contrato .txt";
        public void Guardar(Contrato contrato)
        {

            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{contrato.TipoContrato};{contrato.NumeroIdentificacion};{contrato.NombreContratista};{contrato.ValorContrato};{contrato.FechaSuscripcion.ToString("dd/MM/yyyy")}");
            writer.Close();
            file.Close();
        }

        public Contrato Buscar(string identificacionContratista)
        {
            List<Contrato> contratos  = ConsultarTodos();
            foreach (var item in contratos)
            {
                if (Encontrado(item.NumeroIdentificacion, identificacionContratista))
                {
                    return item;
                }
            }
            return null;
        }

        private bool Encontrado(string identificacionContratistaRegistrado, string identificacionContratistaBuscado)
        {
            return identificacionContratistaRegistrado == identificacionContratistaBuscado;

        }


        public List<Contrato> ConsultarTodos()
        {
            List<Contrato> listadoContratos = new List<Contrato>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;


            while ((linea = reader.ReadLine()) != null)
            {
                Contrato contrato  = Mapear(linea);
                listadoContratos.Add(contrato);
            }
            reader.Close();
            file.Close();
            return listadoContratos;

        }

        private Contrato Mapear(string linea)
        {
            string[] datos = linea.Split(';');
            Contrato contrato = new Contrato();
            contrato.TipoContrato= datos[0];
            contrato.NumeroIdentificacion = datos[1];
            contrato.NombreContratista = datos[2];
            contrato.ValorContrato = datos[3];
            contrato.FechaSuscripcion = DateTime.Parse(datos[4]);
            return contrato;
        }

    }
}
