using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase13.Modelo
{
    internal class Billetera
    {
        // ========== Propiedades ==========
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        // ========== Métodos ==========
        public decimal Total(Billetera billetera)
        {
            var lista = new List<int>();
            var acumulador = 0;

            lista.Add(BilletesDe10 * 10);
            lista.Add(BilletesDe20 * 20);
            lista.Add(BilletesDe50 * 50);
            lista.Add(BilletesDe100 * 100);
            lista.Add(BilletesDe200 * 200);
            lista.Add(BilletesDe500 * 500);
            lista.Add(BilletesDe1000 * 1000);
            foreach (var item in lista)
            {
                acumulador += item;
            }

            //Console.WriteLine(acumulador);
            return acumulador;
        }

        public decimal Combinar(Billetera billetera1, Billetera billetera2)
        {
            var listaCombinada = new List<int>();
            var acumulador = 0;

            listaCombinada.Add(billetera1.BilletesDe10 * 10 + billetera2.BilletesDe10 * 10);
            listaCombinada.Add(billetera1.BilletesDe20 * 20 + billetera2.BilletesDe20 * 20);
            listaCombinada.Add(billetera1.BilletesDe50 * 50 + billetera2.BilletesDe50 * 50);
            listaCombinada.Add(billetera1.BilletesDe100 * 100 + billetera2.BilletesDe100 * 100);
            listaCombinada.Add(billetera1.BilletesDe200 * 200 + billetera2.BilletesDe200 * 200);
            listaCombinada.Add(billetera1.BilletesDe500 * 500 + billetera2.BilletesDe500 * 500);
            listaCombinada.Add(billetera1.BilletesDe1000 * 1000 + billetera2.BilletesDe1000 * 1000);

            foreach (var item in listaCombinada)
            {
                acumulador += item;
            }

            return acumulador;
        }

        public void BilleteraNro3(Billetera billetera1, Billetera billetera2)
        {
            Billetera billetera3 = new Billetera();
            billetera3.BilletesDe10 = billetera1.BilletesDe10 + billetera2.BilletesDe10;
            billetera3.BilletesDe20 = billetera1.BilletesDe20 + billetera2.BilletesDe20;
            billetera3.BilletesDe50 = billetera1.BilletesDe50 + billetera2.BilletesDe50;
            billetera3.BilletesDe100 = billetera1.BilletesDe100 + billetera2.BilletesDe100;
            billetera3.BilletesDe200 = billetera1.BilletesDe200 + billetera2.BilletesDe200;
            billetera3.BilletesDe500 = billetera1.BilletesDe500 + billetera2.BilletesDe500;
            billetera3.BilletesDe1000 = billetera1.BilletesDe1000 + billetera2.BilletesDe1000;
            Console.WriteLine($"\nBilletera3 tiene {billetera3.BilletesDe10} billetes de 10");
            Console.WriteLine($"Billetera3 tiene {billetera3.BilletesDe20} billetes de 20");
            Console.WriteLine($"Billetera3 tiene {billetera3.BilletesDe50} billetes de 50");
            Console.WriteLine($"Billetera3 tiene {billetera3.BilletesDe100} billetes de 100");
            Console.WriteLine($"Billetera3 tiene {billetera3.BilletesDe200} billetes de 200");
            Console.WriteLine($"Billetera3 tiene {billetera3.BilletesDe500} billetes de 500");
            Console.WriteLine($"Billetera3 tiene {billetera3.BilletesDe1000} billetes de 1000");
        }

        public void LimpiarBilletera(Billetera billetera)
        {
            billetera.BilletesDe10 = 0;
            billetera.BilletesDe20 = 0;
            billetera.BilletesDe50 = 0;
            billetera.BilletesDe100 = 0;
            billetera.BilletesDe200 = 0;
            billetera.BilletesDe500 = 0;
            billetera.BilletesDe1000 = 0;
        }

        

    }
}
