using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    class CuentaDeAhorro : IAhorro
    {
        public int numCuenta { get; set; }
        public int balance { get; set; }
        public static List<CuentaDeAhorro> listaCuenta = new List<CuentaDeAhorro>();

        public void Apertura(int numcuen,  int monto)
        {
            int id = listaCuenta.Count;
            listaCuenta.Add(new CuentaDeAhorro());
            //(Crear la cuenta con: #de cuenta y monto apertura
            listaCuenta[id].numCuenta = numcuen;
            listaCuenta[id].balance = monto;
            Console.WriteLine("Cuenta creada satisfactoriamente, recuerde el numero de cuenta..");

        }
        public void Depositos(int numCuen, int dinero)
        {
            //Ingresar dinero y devolver el valor del balance
            int lon = listaCuenta.Count;
            int id = Buscarid(numCuen,lon);
            if (id>=0)
            {
                listaCuenta[id].balance += dinero;
                Console.WriteLine("Balance actual: " + listaCuenta[id].balance);
            }
            else
            {
                Console.WriteLine("Error: Numero de cuenta no encontrado");
            }

        }
        public void Retiros(int numCuen,int dinero)
        {
            //Sacar dinero y devolver el valor del balance
            int lon = listaCuenta.Count;
            int id = Buscarid(numCuen, lon);
            if (id>=0)
            {
                if (listaCuenta[id].balance >= dinero)
                {
                    listaCuenta[id].balance -= dinero;
                    Console.WriteLine("Balance actual: " + listaCuenta[id].balance);
                }
                else
                {
                    Console.WriteLine("Error: Balance insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Error: Numero de cuenta no encontrado");
            }


        }
        public void Consulta(int numCuen)
        {
            //balance (Solo devolver el balance)
            int lon = listaCuenta.Count;
            int id = Buscarid(numCuen, lon);
            if (id>=0)
            {
                Console.WriteLine("Balance actual: " + listaCuenta[id].balance);
            }
            else
            {
                Console.WriteLine("Error: Numero de cuenta no encontrado");
            }
            
        }

        public int Buscarid(int numcuen, int longitud)
        {
            
            for (int i = 0; i < longitud; i++)
            {
                if (numcuen == listaCuenta[i].numCuenta)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
