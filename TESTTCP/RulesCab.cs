using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTCP
{
    //Clase Reglas y validaciones
    public class RulesCab
    {
        private AcessCab _AcessCab;
        //constructor
        public RulesCab()
        {
            _AcessCab = new AcessCab();
        }
        public Cabecera SaveCabecera(Cabecera cabecera)
        {
            //cliente nuevo
            if (cabecera.ID == 0)
                _AcessCab.InsertCabecera(cabecera);
            else
                //editar cliente
                _AcessCab.UpdateCabecera(cabecera);


            return cabecera;
        }

        public List<Cabecera> ClientsSelection(Int32 NumCliente)
        {
            return _AcessCab.ClientsSelection(NumCliente);
        }





        public void DeleteCabecera(int ID)
        {
            _AcessCab.DeleteCabecera(ID);
        }
    }
}
