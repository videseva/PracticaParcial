using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;


namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        ContratoServices contratoServices;
        Contrato contrato;
        IList<Contrato> contratos;

        public FrmPrincipal()
        {
            InitializeComponent();
            contratoServices = new ContratoServices();
            Consultar();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            contrato = new Contrato();
            contrato.TipoContrato = CbxTipoContrato.Text;
            contrato.NumeroIdentificacion = TxtIdentificacionContratista.Text;
            contrato.NombreContratista = TxtNombreContratista.Text;
            contrato.ValorContrato = TxtValorContrato.Text;
            contrato.FechaSuscripcion = Convert.ToDateTime(DtFechaSuscripcion.Value);
            String mensaje = contratoServices.guardar(contrato) + ": ";
            MessageBox.Show(mensaje);
            Consultar();


        }

        public void Consultar()
        {
            DtContratos.Rows.Clear();

            contratos = contratoServices.ConsultarTodos();
            foreach (var item in contratos)
            {
                DtContratos.Rows.Add(item.TipoContrato, item.NumeroIdentificacion, item.NombreContratista, item.FechaSuscripcion, item.ValorContrato);
            }
        }
    }
}
