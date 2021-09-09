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
    public partial class Main : Form
    {
        private Rules _Rules;
        private RulesCab _RulesCab;
        public Main()
        {
            InitializeComponent();
            _Rules = new Rules();
            _RulesCab = new RulesCab();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region Eventos

        
        private void btnadd_Click(object sender, EventArgs e)
        {
            OpenClientsDetailsDialog();
         }

        private void btnaddCab_Click_1(object sender, EventArgs e)
        {
            OpenCabeceraDetailsDialog();
        }
        #endregion

        #region Metodos Privados
        //handler agregar cliente 
        private void OpenClientsDetailsDialog()
        {
            ClientsDetails ClientsDetails = new ClientsDetails();
            ClientsDetails.ShowDialog(this);
        }
        //handler agregar cabecera
        private void OpenCabeceraDetailsDialog()
        {
            CabeceraDetails CabeceraDetails = new CabeceraDetails();
            CabeceraDetails.ShowDialog(this);
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateClients();
            PopulateCabecera();
        }

        public void Ocho()
        {
            List<Clients> clients = _Rules.Ocho();
            gridclients.DataSource = clients;
        }

        public void PopulateClients(string searchText = null)
        {
            List<Clients> clients = _Rules.GetClients(searchText);
            gridclients.DataSource = clients;
        }
        //populate Cabecera
        public void PopulateCabecera(string searchText = null)
        {
            List<Clients> clients = _Rules.GetClientsCab(searchText);
            gridclients.DataSource = clients;
        }
        //click en el grip determianr si es edit o delete
        private void gridclients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridclients.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if(cell.Value.ToString() == "Edit")
            {
                //carga de datos 
                ClientsDetails clientsDetails = new ClientsDetails();
                clientsDetails.LoadClients(new Clients { 
                ID = int.Parse(gridclients.Rows[e.RowIndex].Cells[0].Value.ToString()),
                RazonSocial = gridclients.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Cuit = gridclients.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Direccion = gridclients.Rows[e.RowIndex].Cells[3].Value.ToString(),
                Deshabilitado = bool.Parse((gridclients.Rows[e.RowIndex].Cells[4]).Value.ToString()),

                });;
                clientsDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeleteClients(int.Parse((gridclients.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                PopulateClients();
            }

        }


        private void gridcabecera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridclients.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                //carga de datos 
                CabeceraDetails cabeceraDetails = new CabeceraDetails();
                cabeceraDetails.LoadCabecera(new Cabecera  {
                    ID = int.Parse(gridcabecera.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FechaAlta = gridcabecera.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Estado = gridcabecera.Rows[e.RowIndex].Cells[2].Value.ToString(),
           

                }); ;
                cabeceraDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeleteCabecera(int.Parse((gridclients.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                PopulateCabecera();
            }

        }
        private void DeleteClients(int ID)
        {
            _Rules.DeleteClients(ID);
        }

        private void DeleteCabecera(int ID)
        {
            _RulesCab.DeleteCabecera(ID);
        }

        private void btsearchCAB_Click(object sender, EventArgs e)
        {
            PopulateCabecera(textsearch.Text);
            textsearchCab.Text = string.Empty;
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            PopulateClients(textsearch.Text);
            textsearch.Text = string.Empty;
        }

        private void Filtro_Click(object sender, EventArgs e)
        {
         
            Ocho();
        }

        private void gridcabecera_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridclients.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                //carga de datos 
                CabeceraDetails cabeceraDetails = new CabeceraDetails();
                cabeceraDetails.LoadCabecera(new Cabecera
                {
                    ID = int.Parse(gridcabecera.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FechaAlta = gridcabecera.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Estado = gridcabecera.Rows[e.RowIndex].Cells[2].Value.ToString(),


                }); ;
                cabeceraDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeleteCabecera(int.Parse((gridclients.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                PopulateCabecera();
            }
        }
    }
}
