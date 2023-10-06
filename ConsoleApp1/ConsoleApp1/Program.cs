using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] asientos = new char[10,10];
            string respuesta;
            int filaReserva, colReserva;
            bool errorAsiento = false;
            LimpiarAsientos(asientos);
            Console.WriteLine("BIENVENIDO A LA VENTA DE TICKETS");
            do
            {
                Console.WriteLine("¿Desea ver la lista de asientos? s/S para SI");
                respuesta = Console.ReadLine();
                if(respuesta == "s" || respuesta == "S")
                {
                    MostrarAsientos(asientos);
                }
                Console.WriteLine("¿En que fila desea reservar? de 1 a 10");
                filaReserva = -1 + Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿En que columna desea reservar? de 1 a 10");
                colReserva = -1 + Convert.ToInt32(Console.ReadLine());
                if(filaReserva>=0&&filaReserva<10)
                {
                    if (colReserva >= 0 && colReserva <10)
                    {
                        if (asientos[filaReserva,colReserva] == 'L')
                        {
                            asientos[filaReserva, colReserva] = 'X';
                            Console.WriteLine("Asiento: " + (filaReserva+1) + "-" + (colReserva + 1) + " reservado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Asiento: " + (filaReserva + 1) + "-" + (colReserva + 1) + " se encuentra ocupado.");
                        }
                    }
                    else
                    {
                        errorAsiento = true;
                    }
                }
                else
                {
                    errorAsiento = true;
                }
                if(errorAsiento)
                {
                    errorAsiento = false;
                    Console.WriteLine("Debe ingresar un valor de asiento válido");
                }
                Console.WriteLine("¿Cerrar caja? s/S para SI");
                respuesta = Console.ReadLine();
            } while (!(respuesta == "s" || respuesta == "S"));
        }
        static void LimpiarAsientos(char[,] asientos)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    asientos[i, j] = 'L';
                }
            }
        }
        static void MostrarAsientos(char[,] asientos)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("["+asientos[i, j]+"]");
                }
                Console.WriteLine();
            }
        }
    }
}
