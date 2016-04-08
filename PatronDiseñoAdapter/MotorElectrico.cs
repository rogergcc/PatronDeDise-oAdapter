using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronDiseñoAdapter
{
    public class MotorElectrico
    {
        private bool conectado = false;

        public MotorElectrico()
        {
            Console.WriteLine("Creando motor electrico...");
            this.conectado = false;
        }
        public void conectar()
        {
            Console.WriteLine("Conectando motor comun...");
            this.conectado = true;
        }
        public void activar()
        {
            if (!this.conectado)
            {
                Console.WriteLine("No se puede activar porque no esta conectado el motor electrico.");
            }
            else
            {
                Console.WriteLine("Esta conectado, activando motor electrico.");
            }
        }
        public void moverMasRapido()
        {
            if (!this.conectado)
            {
                Console.WriteLine("No se puede mover rapido porque no esta conectado el motor electrico.");
            }
            else
            {
                Console.WriteLine("Moviendo mas rapido, aumentando voltaje del motor eléctrico.");
            }
        }
        public void detener()
        {
            if (!this.conectado)
            {
                Console.WriteLine("No se puede detener porque no esta conectado el motor electrico.");
            }
            else
            {
                Console.WriteLine("deteniendo el motor eléctrico.");
            }
        }
        public void desconectar()
        {
            Console.WriteLine("Desconectando motor electrico.");
            this.conectado = false;
        }
    }
}