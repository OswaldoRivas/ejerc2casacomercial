using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc2casacomercial
{
    class Program
    {

        class CasaComercial
        {
            string nombre, email;
            int totalVehiculos;
            List<Vehiculo> vehiculos; //esto es un atributo de la clase CasaComercial que es una lista de objetos de la clase Vehiculo

            public CasaComercial(string nombre, string email, int totalVehiculos, List<Vehiculo> vehiculos)
            {
                this.Nombre = nombre;
                this.Email = email;
                this.TotalVehiculos = totalVehiculos;
                this.Vehiculos = vehiculos;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public string Email { get => email; set => email = value; }
            public int TotalVehiculos { get => totalVehiculos; set => totalVehiculos = value; }
            internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

            // añadir los métodos:

            public void aniadirVehiculo(Vehiculo v)
            {
                try
                {
                    //añadimos el vehiculo a la lista
                    this.vehiculos.Add(v);
                    //aumentamos el total de vehiculos
                    this.totalVehiculos += 1;
                    Console.WriteLine("Se ha añadido el vehiculo correctamente");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al añadir el vehiculo: " + e.Message);
                    Console.ReadLine();
                    throw;
                }
            }

            public void mostrarVehiculos()
            {
                try
                {
                    //mostramos la lista de vehiculos
                    foreach (var v in this.vehiculos)
                    {
                        Console.WriteLine(v.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al mostrar los vehiculos: " + e.Message);
                    Console.ReadLine();
                    throw;
                }
            }

            public void vaciarVehiculo()
            {
                Console.WriteLine("Esta seguro que desea vaciar la lista de vehiculos? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta == "s" || respuesta == "S")
                {
                    vehiculos = new List<Vehiculo>();
                    this.totalVehiculos = 0;
                    Console.WriteLine("Se ha vaciado la lista de vehiculos correctamente");
                }
                else
                {
                    Console.WriteLine("No se ha vaciado la lista de vehiculos");
                    Console.ReadLine();
                }
            }

            public void eleminarVehiculo(Vehiculo v)
            {
                vehiculos.Remove(v);
                this.totalVehiculos -= 1;
                Console.WriteLine("Se ha eliminado el vehiculo correctamente");
                Console.ReadLine();
            }
        }

        class Vehiculo
        {
            int id;
            string marca;
            string modelo;
            int km;
            decimal precio;
            int annio;

            public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int annio)
            {
                this.Id = id;
                this.Marca = marca;
                this.Modelo = modelo;
                this.Km = km;
                this.Precio = precio;
                this.Annio = annio;
            }

            public int Id { get => id; set => id = value; }
            public string Marca { get => marca; set => marca = value; }
            public string Modelo { get => modelo; set => modelo = value; }
            public int Km { get => km; set => km = value; }
            public decimal Precio { get => precio; set => precio = value; }
            public int Annio { get => annio; set => annio = value; }

            public override string ToString()
            {
                return "Modelo: " + modelo + "\nMarca: " + marca + "\nKm: " + km + "\nPrecio: " + precio + "\nAño: " + annio + "\n";
            }
        }

        static void Main(string[] args)
        {
            CasaComercial casaComercial = new CasaComercial("autolote el chele", "contacto@gmail.com", 0, new List<Vehiculo>());
            casaComercial.aniadirVehiculo(new Vehiculo(1, "Toyota", "Corolla", 1000, 10000, 2010));

        }
    }
}
