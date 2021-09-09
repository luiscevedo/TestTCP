using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTCP
{
    //Clase Reglas y validaciones
    public class Rules
    {
        private Acess _Acess;
        //constructor
        public Rules()
        {
            _Acess = new Acess();
        }
        public Clients SaveClients(Clients clients)
            {
            //cliente nuevo
            if (clients.ID == 0)
                _Acess.InsertClients(clients);
            else
                //editar cliente
                _Acess.UpdateClients(clients);


            return clients;
             }

        public List<Clients> Ocho()
        {
            return _Acess.Ocho();
        }


        public List<Clients> GetClients(string searchText = null)
        {
           return _Acess.GetClients(searchText); 
        }
        public List<Clients> GetClientsCab(string searchText = null)
        {
            return _Acess.GetClientsCab(searchText);
        }

        public void DeleteClients(int ID)
        {
            _Acess.DeleteClients(ID);
        }
    }
}
