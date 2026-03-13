
using System;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoElectronico prod1 = new ProductoElectronico();
            prod1.Nombre = "Laptop";
            prod1.Codigo = "P1001";
            prod1.Precio = 45000;
            prod1.Cantidad = 5;
            prod1.MesesGarantia = 12;

            Console.WriteLine("PRODUCTO ELECTRONICO:");
            prod1.MostrarProducto();


            ProductoAlimento prod2 = new ProductoAlimento();
            prod2.Nombre = "Leche";
            prod2.Codigo = "A2002";
            prod2.Precio = 75;
            prod2.Cantidad = 20;
            prod2.Vencimiento = "15/05/2026";

            Console.WriteLine("\nDATOS ALIMENTO:");
            prod2.MostrarProducto();
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto() { }

            public virtual double CalcularImpuesto() => 0;

            public virtual void MostrarProducto()
            {
                Console.WriteLine("Articulo: " + Nombre);
                Console.WriteLine("Codigo: " + Codigo);
                Console.WriteLine("Precio: " + Precio);
                Console.WriteLine("Cantidad: " + Cantidad);
            }
        }

        public class ProductoElectronico : Producto
        {
            public int MesesGarantia { get; set; }

            public ProductoElectronico() { }

            public override double CalcularImpuesto()
            {
                return Precio * 0.18;
            }

            public override void MostrarProducto()
            {
                base.MostrarProducto();
                Console.WriteLine("Garantia: " + MesesGarantia + " meses");
                Console.WriteLine("Impuesto: " + CalcularImpuesto());
            }
        }

        public class ProductoAlimento : Producto
        {
            public string Vencimiento { get; set; }

            public ProductoAlimento() { }

            public override double CalcularImpuesto()
            {
                return Precio * 0.08;
            }

            public override void MostrarProducto()
            {
                base.MostrarProducto();
                Console.WriteLine("Vence el: " + Vencimiento);
                Console.WriteLine("Impuesto calculado : " + CalcularImpuesto());
            }
        }
    }
}