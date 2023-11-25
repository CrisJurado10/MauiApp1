using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Utils
{
    internal class Utils
    {
        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto
            {
                IdProducto = 1,
                Nombre = "Producto 1",
                Descripcion = "Descripción 1",
                Cantidad = 10
            },

            new Producto
            {
                IdProducto = 2,
                Nombre = "Producto 2",
                Descripcion = "Descripción 2",
                Cantidad = 15
            },

            new Producto
            {
                IdProducto = 3,
                Nombre = "Producto 3",
                Descripcion = "Descripción 3",
                Cantidad = 20
            },

        };
    }
}
