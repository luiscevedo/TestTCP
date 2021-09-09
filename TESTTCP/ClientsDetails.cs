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
    public partial class ClientsDetails : Form
    {
           //variable global
        private Rules _Rules;
        //Variable globar de clients para optener ID
        private Clients _Clients;
        public ClientsDetails()
        {
            InitializeComponent();
            //acceso a las validaciones 
            _Rules = new Rules();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Cerrar formulario
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //boton Guardar nuevo cliente
        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClients();
            this.Close();
            ((Main)this.Owner).PopulateClients();
        }
        // cargar nuevo cliente desde los txt
        private void SaveClients()
        {
            Clients clients = new Clients();
            clients.RazonSocial = txtRazonSocial.Text;
            clients.Cuit = txtcuit.Text;
            clients.Direccion = txtdireccion.Text;
            clients.Deshabilitado = checkBox1.Checked;

            clients.ID = _Clients != null ? _Clients.ID : 0;

            //grabar clients
            _Rules.SaveClients(clients);
        }
        //actualizar clients editado
        public void LoadClients(Clients clients)
        {
            _Clients = clients;
            if(clients != null)
            {

                ClearForm();
                txtRazonSocial.Text = clients.RazonSocial;
                txtcuit.Text = clients.Cuit;
                txtdireccion.Text = clients.Direccion;
                checkBox1.Checked = clients.Deshabilitado;

            }
        }
        //limpiar formularia
        private void ClearForm()
        {
            txtRazonSocial.Text = String.Empty;
            txtcuit.Text = String.Empty;
            txtdireccion.Text = String.Empty;
            checkBox1.Checked = false;
        }
    }
}
