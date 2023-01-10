using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_5
{
    class CertificadosFinancieros
    {
        public int numCertificado { get; set; }
        public int monto { get; set; }//el valor maximo de la tarjeta
        public int duracion { get; set; } // en meses
        public static List<CertificadosFinancieros> listaCert = new List<CertificadosFinancieros>();

        public void Apertura(int numCer,int monto,int tiempo)
        {
            //Crear el certificado con: #de certificado, monto y tiempo de duracion
            int id = listaCert.Count;
            listaCert.Add(new CertificadosFinancieros());
            listaCert[id].numCertificado = numCer;
            listaCert[id].monto = monto;
            listaCert[id].duracion = tiempo;
            Console.WriteLine("Certificado Financiero  creado satisfactoriamente, recuerde el numero de Certificado Financiero..");


        }
        public void ConsultaDeInteres(int numCer)
        {

            //Devolver un valor arbitrario
            int lon = listaCert.Count;
            int id = Buscarid(numCer, lon);
            if (id >= 0)
            {
                int Interes = listaCert[id].monto * ((7/(12+1))^listaCert[id].duracion);
                Console.WriteLine("Interes Certificado financiero: " + Interes);
            }
            else
            {
                Console.WriteLine("Error: Numero de cuenta no encontrado");
            }
        }
        public int Buscarid(int numCer, int longitud)
        {

            for (int i = 0; i < longitud; i++)
            {
                if (numCer == listaCert[i].numCertificado)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
