using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTTCP
{
    public partial class CabeceraDetails : Form
    {           
        //variable global
        private RulesCab _RulesCab;
        //Variable globar de clients para optener ID
        private Cabecera _Cabecera;
        public CabeceraDetails()
        {
            InitializeComponent();
            //acceso a las validaciones 
            _RulesCab = new RulesCab();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
                    this.Close();
        }

        private void btncancelCAB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsaveCAB_Click(object sender, EventArgs e)
        {
            SaveCabecera();
            this.Close();
            ((Main)this.Owner).PopulateClients();
        }

        private void SaveCabecera()
        {
            Cabecera cabecera = new Cabecera();
            cabecera.FechaAlta = dateTimePicker1.Value.ToShortDateString();
            cabecera.Estado = txtEstado.Text;

            cabecera.ID = _Cabecera != null ? _Cabecera.ID : 0;

            //grabar clients
            _RulesCab.SaveCabecera(cabecera);

           
        }

        public void LoadCabecera(Cabecera cabecera)
        {
            _Cabecera = cabecera;
            if (cabecera != null)
            {

                ClearFormCab();

                dateTimePicker1.CustomFormat = cabecera.FechaAlta;
                txtEstado.Text = cabecera.Estado;

            }
            //Limpa formualrio
        }

        private void ClearFormCab()
        {
            txtEstado.Text = String.Empty;
           
        }

        private void txtNumCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarNumCliente_Click(object sender, EventArgs e)
        {
            OpenBuscarClientDialog();
        }
        private void OpenBuscarClientDialog()
        {
            BuscarClient BuscarClient = new BuscarClient();
            BuscarClient.ShowDialog(this);
        }
    }
}
