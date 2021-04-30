using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicafinal
{
    class Program
    {
        static void Main(string[] args)
        {

            double pago;
            double Interesp;
            double abonado;
            double monto;
            double interesa;
            double interesmensual;
            int coutas;
            double plazos;
            int fila;

            Console.Write("Digita el monto del prestamo: ");
            monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digita la tasa de interes anual: ");
            interesa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digita el numero de coutas en meses: ");
            coutas = Convert.ToInt32(Console.ReadLine());



            interesmensual = (interesa / 100) / 12;
            plazos = interesmensual + 1;
            plazos = (float)Math.Pow(plazos, coutas) - 1;
            plazos = interesmensual / plazos;
            plazos = interesmensual + plazos;
            plazos = monto * plazos;

            Console.Clear();

            Console.WriteLine("Monto del prestamo en RD$\t\t\t" + monto);
            Console.WriteLine("tasa de porcentaje anual\t\t\t" + interesa + " %");
            Console.WriteLine("Plazo\t\t\t\t\t\t\t\t" + coutas + " meses");
            Console.WriteLine("Valor cuota\t\t\t\t\t\t\t" + plazos);

            fila = 1;

            Console.Write("\n plazo No° \t");
            Console.Write("Pago \t\t\t\t\t");
            Console.Write("Intereses Pagados \t");
            Console.Write("Capital Pagado \t\t");
            Console.Write("Capital Final \t");

            Console.Write("\t");
            Console.WriteLine("\t\t\t\t");


            for (int i = 1; i <= coutas; i++)
            {


                Console.Write("\t{0}\t\t", fila);


                Console.Write("{0}\t\t", plazos);


                Interesp = interesmensual * monto;
                Console.Write("{0}\t\t\t\t", Interesp);


                abonado = plazos - Interesp;
                Console.Write("{0}\t", abonado);


                monto = monto - abonado;
                Console.Write("\t{0}\t", monto);

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}