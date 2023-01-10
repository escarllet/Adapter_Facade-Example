using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    class Fachada
    {
        private CuentaDeAhorro cuenta;
        private Prestamos prestamos;
        private CertificadosFinancieros certificados;

        public void CuentaDeAhorro()
        {
            Console.WriteLine("App de Celular/Cuenta de ahorro/Consulta\n\n" +
            "Aqui podras Consultar el balance de tu cuenta, se necesita el numero de cuenta \n" +
            "Ingrese el numero de cuenta:");
            int numcu3 = Convert.ToInt32(Console.ReadLine());
            cuenta = new CuentaDeAhorro();
            cuenta.Consulta(numcu3);
        }
        public void Prestamo()
        {
            Console.WriteLine("App de Celular/Prestamo/Pago de prestamo\n\n" +
            "Aqui paga un prestamo \n" +
            "Ingrese el numero de prestamo:");
            int numpres1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto total del prestamo:");
            int monto1 = Convert.ToInt32(Console.ReadLine());
            prestamos = new Prestamos();
            prestamos.PagoPrestamo(numpres1, monto1);
        }
        public void Certificados()
        {
            Console.WriteLine("App de Celular/Certificados Financieros/Consulta de interes\n\n" +
            "Aqui podras Consultar el Interes de tu Certificado, se necesita el numero de Certificado \n" +
            "Ingrese el numero de Certificado:");
            int numcu3 = Convert.ToInt32(Console.ReadLine());
            certificados = new CertificadosFinancieros();
            certificados.ConsultaDeInteres(numcu3);
        }
    }
}
