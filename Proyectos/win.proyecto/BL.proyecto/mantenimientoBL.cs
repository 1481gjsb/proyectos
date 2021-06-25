using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto 
{
    public class mantenimientoBL
    {
        public BindingList<manteni> Listamantenimientos { get; set; }
        public mantenimientoBL()
        {
            Listamantenimientos = new BindingList<manteni>();

            var manteni1 = new manteni();
            manteni1.Id = 6;
            manteni1.descripcion = "Descargar camion bloques";
            manteni1.Area = "bodega 4";
            manteni1.Hora = 1300;
            manteni1.activo = true;

            Listamantenimientos.Add(manteni1);

            var manteni2 = new manteni();
            manteni2.Id = 9;
            manteni2.descripcion = "Clasificacion de varillas";
            manteni2.Area = "Bodega 5  ";
            manteni2.Hora = 1500;
            manteni2.activo = true;

            Listamantenimientos.Add(manteni2);

            var manteni3 = new manteni();
            manteni3.Id = 4;
            manteni3.descripcion = "Descargar bolsas de cemento";
            manteni3.Area = "Bodega 2";
            manteni3.Hora = 1700;
            manteni3.activo = true;

            Listamantenimientos.Add(manteni3);

        }


        public BindingList<manteni> obtenermantenimientos()
        {
            return Listamantenimientos;

        }
        public class manteni
        {
            public int Id { get; set; }
            public string descripcion { get; set; }
            public string Area { get; set; }
            public int Hora { get; set; }
            public bool activo { get; set; }
        }
    }
}