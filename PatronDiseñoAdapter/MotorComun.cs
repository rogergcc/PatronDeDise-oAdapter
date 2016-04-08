using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronDiseñoAdapter
{
    public class MotorComun : Motor
    {
        public MotorComun():base()
        {
            Console.WriteLine("Creando motor comun...");
        }

        public override void acelerar()
        {
            Console.WriteLine("Acelerar motor comun...");
        }

        public override void apagar()
        {
            Console.WriteLine("Apagar motor comun...");
        }

        public override void encender()
        {
            Console.WriteLine("Encender motor comun...");
        }
    }
}