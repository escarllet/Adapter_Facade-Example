using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    class CuentaDeSuperAhorro
    {
        // solo para super ahorro
        public bool ValidadRetiro(int bal,int retiro)
        {
            /*La lógica de este método es recibir el monto a retirar y verificar 
             * si es 40% o menos del balance. Si es asi, llama al metodo para 
             * retirar. En caso contrario notifica al usuario con un mensaje.
             */
            float cuartentaPorciento = bal * 0.4f;
            if (retiro<=cuartentaPorciento)
            {
                return true;
            }
            else
            {
                Console.WriteLine("El retiro es mayor al cuarenta porciento del balance");
                return false;
            }
        }
    }
}
