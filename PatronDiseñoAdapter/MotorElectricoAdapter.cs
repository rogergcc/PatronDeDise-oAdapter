using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronDiseñoAdapter
{
    public class MotorElectricoAdapter : Motor
    {
        private MotorElectrico motorElectrico;

        public MotorElectricoAdapter() :base()
        {
            Console.WriteLine("Creando motor electrico adapter...");
            this.motorElectrico = new MotorElectrico();
        }

        public override void encender()
        {
            Console.WriteLine("Encendiendo motor electrico adapter...");
            this.motorElectrico.conectar();
            this.motorElectrico.activar();
        }

        public override void acelerar()
        {
            Console.WriteLine("Acelerando motor electrico adapter...");
            this.motorElectrico.moverMasRapido();
        }

        public override void apagar()
        {
            Console.WriteLine("Encendiendo motor electrico adapter...");
            this.motorElectrico.detener();
            this.motorElectrico.desconectar();
        }
        
    }
}