using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ContratoServices
    {

        private ContratoRepository contratoRepository = new ContratoRepository();
        public String guardar(Contrato contrato)
        {
            try
            {
                if (contratoRepository.Buscar(contrato.NumeroIdentificacion) == null)
                {
                    contratoRepository.Guardar(contrato);
                    return "contrato Guardado.";
                }
                else
                {
                    return "no se  registro el contrato";
                }
            }
            catch (Exception e)
            {
                return "erro no se pudo guardad" + e.Message;
            }

        }

        public List<Contrato> ConsultarTodos()
        {
            List<Contrato> listadoscontratos = contratoRepository.ConsultarTodos();
            return listadoscontratos;
        }

     

    }
}
