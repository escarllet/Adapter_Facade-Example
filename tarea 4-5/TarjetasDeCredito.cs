using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    class TarjetasDeCredito
    {
        public int numtarjeta { get; set; }
        public int limite { get; set; }//el valor maximo de la tarjeta
        public int balance { get; set; }//lo que tiene consumido]
        public int disponible { get; set; } //lo que le queda disponible
        public static List<TarjetasDeCredito> listatarj = new List<TarjetasDeCredito>();

        public void Expedicion(int numtar,int lim)
        {
            //Crear la tarjeta con: #tarjeta, limite
            int id = listatarj.Count;
            listatarj.Add(new TarjetasDeCredito());

            listatarj[id].numtarjeta = numtar;
            listatarj[id].limite = lim;
            listatarj[id].disponible = listatarj[id].limite;
            Console.WriteLine("Tarjeta creada satisfactoriamente, recuerde el numero de tarjeta..");

        }
        public void Consumos( int numtar, int consumo)
        {
            //Recibir un valor y mostrar un mensaje diciendo el monto consumido y el monto disponible
            int lon = listatarj.Count;
            int id = Buscarid(numtar, lon);
            if (id>=0)
            {
                if (listatarj[id].disponible >= consumo)
                {
                    listatarj[id].disponible -= consumo;
                    listatarj[id].balance += consumo;
                    Console.WriteLine("Monto consumido: " + listatarj[id].balance + "\nMonto disponible: " + listatarj[id].disponible);
                }
                else
                {
                    Console.WriteLine("Error: Se ha excedido el limite");
                }
            }
            else
            {
                Console.WriteLine("Error: Numero de tarjeta no encontrado");
            }

        }
        public void Pagos(int numtar,int pagado)
        {
            //Recibir un valor y mostrar un mensaje diciendo el monto pagado y el monto disponible)
            int lon = listatarj.Count;
            int id = Buscarid(numtar, lon);
            if (id>=0)
            {
                listatarj[id].disponible += pagado;
                Console.WriteLine("Monto pagado: " + pagado + "\nMonto disponible: " + listatarj[id].disponible);

            }
            else
            {
                Console.WriteLine("Error: Numero de tarjeta no encontrado");
            }

        }
        public int Buscarid(int numtar, int longitud)
        {

            for (int i = 0; i < longitud; i++)
            {
                if (numtar == listatarj[i].numtarjeta)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
