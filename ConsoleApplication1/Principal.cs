using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronDiseñoAdapter;
namespace ConsoleApplication1
{
    public class Principal
    {
        
        private static Motor motor;
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                opcion = preguntarOpcion();
                switch (opcion)
                {
                    case 1:
                        motor = new MotorComun();
                        usarMotor();
                        break;
                    case 2:
                        motor = new MotorEconomico();
                        usarMotor();
                        break;
                    case 3:
                        motor = new MotorElectricoAdapter();
                        usarMotor();
                        break;
                    case 4:
                        Console.WriteLine("Cerrando programa");
                        break;
                    default:
                        Console.WriteLine("La opcion ingresa NO es valida");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine();
            } while (opcion != 4);
        }

        private static void usarMotor()
        {
            motor.encender();
            motor.acelerar();
            motor.apagar();
            Console.ReadKey();
        }

        private static int preguntarOpcion()
        {
            Console.WriteLine(
                "MENU DE OPCIONES\n"
               +"---- -- --------\n"
               + "1. Encender motor común\n"
               + "2. Encender motor económico\n"
               + "3. Encender motor eléctrico\n"
               + "4. Salir. \n"
               +"Seleccionar opcion: "
            );
            return Int32.Parse(Console.ReadLine());
                
        }
    }
}
