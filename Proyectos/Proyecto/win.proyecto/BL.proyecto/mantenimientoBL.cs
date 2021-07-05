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
        public BindingList<Manteni> Listamantenimientos { get; set; }
        public mantenimientoBL()
        {
            Listamantenimientos = new BindingList<Manteni>();

            var manteni1 = new Manteni();
            manteni1.Id = 6;
            manteni1.descripcion = "Descargar camion bloques";
            manteni1.Area = "bodega 4";
            manteni1.Hora = 1300;
            manteni1.activo = true;

            Listamantenimientos.Add(manteni1);

            var manteni2 = new Manteni();
            manteni2.Id = 9;
            manteni2.descripcion = "Clasificacion de varillas";
            manteni2.Area = "Bodega 5  ";
            manteni2.Hora = 1500;
            manteni2.activo = true;

            Listamantenimientos.Add(manteni2);

            var manteni3 = new Manteni();
            manteni3.Id = 4;
            manteni3.descripcion = "Descargar bolsas de cemento";
            manteni3.Area = "Bodega 2";
            manteni3.Hora = 1700;
            manteni3.activo = true;

            Listamantenimientos.Add(manteni3);

        }


        public BindingList<Manteni> obtenermantenimientos()
        {
            return Listamantenimientos;

        }

        public Resultado Guardarmantenimiento(Manteni mantenimiento)
        {
            var resultado = Validar(mantenimiento);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (mantenimiento.Id == 0)
            {
                mantenimiento.Id = Listamantenimientos.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }
        public void Agregarmantenimiento()
        {
            var nuevomanteni = new Manteni();
            Listamantenimientos.Add(nuevomanteni);
        }



        public bool Eliminarmantenimiento(int id)
        {
            foreach (var mantenimiento in Listamantenimientos)
            {
                if (mantenimiento.Id == id)
                {
                    Listamantenimientos.Remove(mantenimiento);
                    return true;
                }


            }
            return false;
        }
        
        private Resultado Validar(Manteni manteni)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(manteni.descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }
            if (manteni.Area == "")
            {
                resultado.Mensaje = "Ingrese un area";
                resultado.Exitoso = false;
            }
            if (manteni.Hora < 0)
            {
                resultado.Mensaje = "La hora debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            return resultado;
        }
        
    }
    public class Manteni
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public string Area { get; set; }
        public int Hora { get; set; }
        public bool activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

