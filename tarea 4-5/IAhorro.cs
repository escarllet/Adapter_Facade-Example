using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    interface IAhorro
    {
  
        void Apertura(int numcuen, int monto);
        void Depositos(int numCuen, int dinero);
        void Retiros(int numCuen, int dinero);
        void Consulta(int numCuen);

    }
}
