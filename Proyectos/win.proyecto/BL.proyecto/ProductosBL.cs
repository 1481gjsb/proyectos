using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto 
{
    public class ProductosBL
    {
         public BindingList<producto> ListaProductos {get; set; }
        public ProductosBL()
        {
            ListaProductos = new BindingList<producto>();

            var producto1 = new producto();
            producto1.Id = 1;
            producto1.descripcion = "Taladro";
            producto1.precio = 12000;
            producto1.existencia = 15;
            producto1.activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new producto();
            producto2.Id = 1;
            producto2.descripcion = "Martillo";
            producto2.precio = 70;
            producto2.existencia = 50;
            producto2.activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new producto();
            producto3.Id = 1;
            producto3.descripcion = "Bolsa de cemento";
            producto3.precio = 300;
            producto3.existencia = 200;
            producto3.activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new producto();
            producto4.Id = 1;
            producto4.descripcion = "Planta Energia";
            producto4.precio = 25000;
            producto4.existencia = 10;
            producto4.activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new producto();
            producto5.Id = 1;
            producto5.descripcion = "Varilla de Hierro";
            producto5.precio = 50;
            producto5.existencia = 800;
            producto5.activo = true;

            ListaProductos.Add(producto5);
        } 
        public BindingList<producto> obtenerproductos()
        {
            return ListaProductos;
        }
    } 

    }
    public class producto
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
        public bool activo { get; set; }
    }

