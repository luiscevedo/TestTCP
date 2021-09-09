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
    public partial class BuscarClient : Form
    {
        private Rules _Rules;
        private RulesCab _RulesCab;
        public BuscarClient()
        {
            _Rules = new Rules();
            _RulesCab = new RulesCab();
            InitializeComponent();
        }
        public Cabecera ClientsSelection { get; set; }

    public void PopulateCabecera(string searchText = null)
        {
            List<Clients> clients = _Rules.GetClientsCab(searchText);
            gridclients.DataSource = clients;
        }
        private void btnBuscarClients_Click(object sender, EventArgs e)
        {
            PopulateCabecera(txtIDclients.Text);
            txtIDclients.Text = string.Empty;
        }

        private void gridclients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridclients.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Seleccionar")
            {
                Int32 NumCliente = Convert.ToInt32(gridclients.CurrentRow.Cells[0].Value);

                List<Cabecera> cabecera = _RulesCab.ClientsSelection(NumCliente);
                this.Close();

            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Cliente");
            }
            CabeceraDetails cabeceraDetails = new CabeceraDetails();
            cabeceraDetails.LoadCabecera(new Cabecera
            {
                ID = int.Parse(gridclients.Rows[e.RowIndex].Cells[0].Value.ToString()),
                //  FechaAlta = gridclients.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Cli_ID = int.Parse(gridclients.Rows[e.RowIndex].Cells[2].Value.ToString()),
                // Estado = gridclients.Rows[e.RowIndex].Cells[3].Value.ToString(),

            }); ;

            /*
        private void btnsaveID_Click(object sender, EventArgs e)
        {
            if (gridclients.SelectedRows.Count == 1) // si selecciona un fila
            {
                CabeceraDetails cabeceraDetails = new CabeceraDetails();
            cabeceraDetails.LoadCabecera(new Cabecera
            {
                Cli_ID = int.Parse(gridclients.Rows[e.RowIndex].Cells[0].Value.ToString()),

            }); 
                Int32 NumCliente = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value); //asignamos el NumCliente seleccionado en el data
                ClienteSeleccionado = PersonaDAL.ObtenerCliente(NumCliente);//llenamos clienteseleccionado con el qe se ha buscado en la BD por el numcliente qe eligio
                this.Close();
            }

            */
            /*
        if (dgvResultado.SelectedRows.Count == 1) // si selecciona un fila
        {
            Int32 NumCliente = Convert.ToInt32(gridclients.CurrentRow.Cells[0].Value); //asignamos el NumCliente seleccionado en el data
            ClienteSeleccionado = PersonaDAL.ObtenerCliente(NumCliente);//llenamos clienteseleccionado con el qe se ha buscado en la BD por el numcliente qe eligio
            this.Close();
        }
        else
        {
            MessageBox.Show("Aun no ha seleccionado Ningun Cliente");
        }
        */

        }
        private void btnsaveID_Click(object sender, EventArgs e)
        {
           
        }
    }
}
