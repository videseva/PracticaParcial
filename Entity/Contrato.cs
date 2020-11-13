using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contrato
    {

       public string TipoContrato { get; set; }
       public string NumeroIdentificacion { get; set; }
       public string NombreContratista { get; set; }
        public DateTime FechaSuscripcion { get; set; }
        public string ValorContrato { get; set; }
        

        public Contrato()
        {

        }

    }
}
