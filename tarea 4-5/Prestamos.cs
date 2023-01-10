using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    class Prestamos
    {
        public int numPrestamo { get; set; }
        public float monto { get; set; }
        public int tasa { get; set; }
        public static List<Prestamos> listaPrest = new List<Prestamos>();

        public void Solicitud(int numpres,int dinero,int tasa)
        {
            //(Crear el prestamo con: #de prestamo, monto[en RD$] y tasa
            int id = listaPrest.Count;
            
            listaPrest.Add(new Prestamos());
            listaPrest[id].numPrestamo = numpres;         
            listaPrest[id].tasa = tasa;
            float porciento = dinero * (tasa / 100);
            listaPrest[id].monto = dinero + porciento;
            Console.WriteLine("Deuda con la tasa aplicada: "+listaPrest[id].monto);
            Console.WriteLine("Prestamo Registrado satisfactoriamente, recuerde el numero de prestamo..");

        }
        public void PagoPrestamo(int numpres, int dinero )
        {
            //Recibir un valor, restarselo al monto del prestamo y devolver lo que queda adecuado

            int lon = listaPrest.Count;
            int id = Buscarid(numpres, lon);
            if (id>=0)
            {
                listaPrest[id].monto -= dinero;
                Console.WriteLine("Deuda actual: " + listaPrest[id].monto);
            }
            else
            {
                Console.WriteLine("Error: Numero de prestamo no encontrado");
            }

        }
        public int Buscarid(int numpres, int longitud)
        {

            for (int i = 0; i < longitud; i++)
            {
                if (numpres == listaPrest[i].numPrestamo)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
