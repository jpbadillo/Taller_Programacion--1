using System;
using Logica;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{

    internal class Menu
    {
        public void MenuPrincipal()
        {
            int opcion;
            do 
            { 
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Registrar Liquidación");
                Console.WriteLine("2. Listar Liquidaciones");
                Console.WriteLine("3. Consultar por Tipo de Afiliación");
                Console.WriteLine("4. Consultar Total de Cuotas Moderadoras");
                Console.WriteLine("5. Consultar por Mes y Año");
                Console.WriteLine("6. Consultar por Nombre");
                Console.WriteLine("7. Eliminar Liquidación");
                Console.WriteLine("8. Modificar Valor de Servicio");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Lógica para registrar una liquidación
                        break;
                    case 2:
                        // Lógica para listar liquidaciones
                        break;
                    // Implementa las demás opciones del menú
                    case 9:
                        
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }while(opcion != 3);
        }
    }
}
