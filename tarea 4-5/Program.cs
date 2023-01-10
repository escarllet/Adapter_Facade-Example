using System;

namespace tarea_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion;
            IAhorro ahorro;
            Prestamos prestamos = new Prestamos();
            CertificadosFinancieros certificados = new CertificadosFinancieros();
            TarjetasDeCredito tarjetas = new TarjetasDeCredito();
            Fachada fachada = new Fachada();
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Banco 'Banca'\nQue desea hacer(Ingrese el numero)?" +
                "\n1.App de escritorio\n2.App para celular\n\n=========================================" +
                "\n0.Salir del programa");
                eleccion = Convert.ToInt32(Console.ReadLine());
                switch (eleccion)
                {
                    case 0:
                        break;
                    case 1:
                        int eleccion2;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("App de escritorio\nQue desea hacer(Ingrese el numero)?" +
                            "\n1.Cuenta de ahorro:Comun y Super" +
                            "\n2.Prestamo" +
                            "\n3.Tarjetas de credito"+
                            "\n4.Certificados Financieros"+
                            "\n\n=======================================================" +
                            "\n0.menu anterior");
                             eleccion2 = Convert.ToInt32(Console.ReadLine());
                            switch (eleccion2)
                            {
                                case 0:
                                    break;
                                case 1:
                                    int eleccion5;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("App de escritorio/Cuenta de ahorro\nQue desea hacer(Ingrese el numero)?" +
                                        "\n1.Cuenta de ahorro comun" +
                                        "\n2.Cuenta de Super ahorro" +
                                        "\n\n=======================================================" +
                                        "\n0.menu anterior");
                                         eleccion5 = Convert.ToInt32(Console.ReadLine());
                                        if (eleccion5==1)
                                        {
                                            int eleccion7;
                                           ahorro = new CuentaDeAhorro();
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de ahorro comun\nQue desea hacer(Ingrese el numero)?" +
                                                "\n1. Apertura" +
                                                "\n2. Deposito" +
                                                "\n3. Retiro" +
                                                "\n4. Consulta" +
                                                "\n\n=======================================================" +
                                                "\n0.Menu anterior");
                                                eleccion7 = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                                switch (eleccion7)
                                                {
                                                    case 0:
                                                        break;
                                                    case 1:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de ahorro comun/Apertura\n\n" +
                                                            "Aqui podra crear una cuenta de ahorro\n" +
                                                            "Ingrese el numero de cuenta:");
                                                        int numcu = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el balance incial:");
                                                        int bal = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Apertura(numcu, bal);
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de ahorro comun/Deposito\n\n" +
                                                        "Aqui podras depositar en tu cuenta de ahorro, se necesita el numero de cuenta \n" +
                                                        "Ingrese el numero de cuenta:");
                                                        int numcu1 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el Dinero a depositar:");
                                                        int dinero = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Depositos(numcu1, dinero);
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de ahorro comun/Retiro\n\n" +
                                                        "Aqui podras retirar de tu cuenta de ahorro, se necesita el numero de cuenta \n" +
                                                        "Ingrese el numero de cuenta:");
                                                        int numcu2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el Dinero a Retirar:");
                                                        int dinero2 = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Retiros(numcu2, dinero2);
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de ahorro comun/Consulta\n\n" +
                                                        "Aqui podras Consultar el balance de tu cuenta, se necesita el numero de cuenta \n" +
                                                        "Ingrese el numero de cuenta:");
                                                        int numcu3 = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Consulta(numcu3);
                                                        break;
                                                    default:
                                                        Console.WriteLine("Error: Ingrese un valor valido");

                                                        break;
                                                }
                                                Console.WriteLine("==============================================");
                                                Console.WriteLine("Presione cualquier tecla para Continuar.");
                                                Console.ReadKey();
                                            } while (eleccion7 != 0);
                                        }
                                        else if (eleccion5 == 2)
                                        {
                                            ahorro = new Adaptador();
                                            int eleccion6;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de Super ahorro\nQue desea hacer(Ingrese el numero)?" +
                                                "\n1. Apertura" +
                                                "\n2. Deposito" +
                                                "\n3. Retiro" +
                                                "\n4. Consulta" +
                                                "\n\n=======================================================" +
                                                "\n0.Menu anterior");
                                                eleccion6 = Convert.ToInt32(Console.ReadLine());
                                                switch (eleccion6)
                                                {
                                                    case 0:
                                                        break;
                                                    case 1:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de Super ahorro/Apertura\n\n" +
                                                            "Aqui podra crear una cuenta de ahorro\n" +
                                                            "Ingrese el numero de cuenta:");
                                                        int numcu = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el balance incial:");
                                                        int bal = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Apertura(numcu, bal);
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de Super ahorro/Deposito\n\n" +
                                                        "Aqui podras depositar en tu cuenta de ahorro, se necesita el numero de cuenta \n" +
                                                        "Ingrese el numero de cuenta:");
                                                        int numcu1 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el Dinero a depositar:");
                                                        int dinero = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Depositos(numcu1, dinero);
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de Super ahorro/Retiro\n\n" +
                                                        "Aqui podras retirar de tu cuenta de ahorro, se necesita el numero de cuenta \n" +
                                                        "Ingrese el numero de cuenta:");
                                                        int numcu2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el Dinero a Retirar:");
                                                        int dinero2 = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Retiros(numcu2, dinero2);
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("App de escritorio/Cuenta de ahorro/Cuenta de Super ahorro/Consulta\n\n" +
                                                        "Aqui podras Consultar el balance de tu cuenta, se necesita el numero de cuenta \n" +
                                                        "Ingrese el numero de cuenta:");
                                                        int numcu3 = Convert.ToInt32(Console.ReadLine());
                                                        ahorro.Consulta(numcu3);
                                                        break;
                                                    default:
                                                        Console.WriteLine("Error: Ingrese un valor valido");
                                                        Console.WriteLine("==============================================");
                                                        Console.WriteLine("Presione cualquier tecla para Continuar.");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                                Console.WriteLine("==============================================");
                                                Console.WriteLine("Presione cualquier tecla para Continuar.");
                                                Console.ReadKey();
                                            } while (eleccion6 != 0);
                                        }
                                        
                                    } while (eleccion5 != 0);

                                    break;
                                case 2:
                                    int eleccion4;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("App de escritorio/Prestamo\nQue desea hacer(Ingrese el numero)?" +
                                        "\n1. Solicitud" +
                                        "\n2. Pago de prestamo" +
                                        "\n\n=======================================================" +
                                        "\n0.Menu anterior");
                                        eleccion4 = Convert.ToInt32(Console.ReadLine());
                                        switch (eleccion4)
                                        {
                                            case 0:
                                                break;
                                            case 1:
                                                Console.WriteLine("App de escritorio/Prestamo/Solicitud\n\n" +
                                                "Aqui se Registra un prestamo \n" +
                                                 "Ingrese el numero de prestamo:");
                                                int numpres = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el monto total del prestamo:");
                                                int monto = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese la tasa del prestamo:");
                                                int tasa = Convert.ToInt32(Console.ReadLine());
                                                prestamos.Solicitud(numpres, monto, tasa);
                                                break;
                                            case 2:
                                                Console.WriteLine("App de escritorio/Prestamo/Pago de prestamo\n\n" +
                                                "Aqui paga un prestamo \n" +
                                                "Ingrese el numero de prestamo:");
                                                int numpres1 = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el monto total del prestamo:");
                                                int monto1 = Convert.ToInt32(Console.ReadLine());
                                                prestamos.PagoPrestamo(numpres1, monto1);
                                                break;
                                            default:
                                                Console.WriteLine("Error: Ingrese un valor valido");

                                                break;
                                        }
                                        Console.WriteLine("==============================================");
                                        Console.WriteLine("Presione cualquier tecla para Continuar.");
                                        Console.ReadKey();
                                    } while (eleccion4 != 0);
                                    break;
                                case 3:
                                    int eleccion3;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("App de escritorio/Tarjetas de Credito\nQue desea hacer(Ingrese el numero)?" +
                                        "\n1. Expedicion" +
                                        "\n2. Consumos" +
                                        "\n3. Pagos" +
                                        "\n\n=======================================================" +
                                        "\n0.Menu anterior");
                                        eleccion3 = Convert.ToInt32(Console.ReadLine());
                                        switch (eleccion3)
                                        {
                                            case 0:
                                                break;
                                            case 1:
                                                Console.WriteLine("App de escritorio/Tarjetas de credito/Expedicion\n\n" +
                                                "Aqui podra expedir una tarjeta de credito\n" +
                                                "Ingrese el numero de tarjeta de credito:");
                                                int numcu = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el Limite de la tarjeta:");
                                                int lim = Convert.ToInt32(Console.ReadLine());
                                                tarjetas.Expedicion(numcu, lim);
                                                break;
                                            case 2:
                                                Console.WriteLine("App de escritorio/Tarjetas de credito/Consumo\n\n" +
                                                "Aqui podras registrar el consumo de la tarjeta, se necesita el numero de tarjeta\n" +
                                                "Ingrese el numero de tarjeta de credito:");
                                                int numcu1 = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el consumo:");
                                                int cons = Convert.ToInt32(Console.ReadLine());
                                                tarjetas.Consumos(numcu1, cons);
                                                break;
                                            case 3:
                                                Console.WriteLine("App de escritorio/Tarjetas de credito/Pagos\n\n" +
                                                "Aqui se paga lo que se debe de la tarjeta, se necesita el numero de tarjeta\n" +
                                                "Ingrese el numero de tarjeta de credito:");
                                                int numcu2 = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el Pago:");
                                                int pago = Convert.ToInt32(Console.ReadLine());
                                                tarjetas.Pagos(numcu2, pago);
                                                break;
                                            default:
                                                Console.WriteLine("Error: Ingrese un valor valido");
                                                Console.WriteLine("==============================================");
                                                Console.WriteLine("Presione cualquier tecla para Continuar.");
                                                Console.ReadKey();
                                                break;
                                        }
                                        Console.WriteLine("==============================================");
                                        Console.WriteLine("Presione cualquier tecla para Continuar.");
                                        Console.ReadKey();
                                    } while (eleccion3 != 0);
                                    break;
                                case 4:
                                    int eleccion8;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("App de escritorio/Certificados Financieros\nQue desea hacer(Ingrese el numero)?" +
                                        "\n1. Apertura" +
                                        "\n2. Consulta de interes" +
                                        "\n\n=======================================================" +
                                        "\n0.Menu anterior");
                                        eleccion8 = Convert.ToInt32(Console.ReadLine());
                                        switch (eleccion8)
                                        {
                                            case 0:
                                                break;
                                            case 1:
                                                Console.WriteLine("App de escritorio/Certificados Financieros/Apertura\n\n" +
                                                "Aqui podra registrar un Cerfificado financiero\n" +
                                                "Ingrese el numero de Cerfificado financiero:");
                                                int numcer = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el monto:");
                                                int monto = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese el tiempo de duracion(en meses):");
                                                int tiempo = Convert.ToInt32(Console.ReadLine());
                                                certificados.Apertura(numcer, monto, tiempo);
                                                break;
                                            case 2:
                                                Console.WriteLine("App de escritorio/Certificados Financieros/Consulta de interes\n\n" +
                                                "Aqui podras Consultar el Interes de tu Certificado, se necesita el numero de Certificado \n" +
                                                "Ingrese el numero de Certificado:");
                                                int numcu3 = Convert.ToInt32(Console.ReadLine());
                                                certificados.ConsultaDeInteres(numcu3);
                                                break;
                                            default:
                                                Console.WriteLine("Error: Ingrese un valor valido");

                                                break;
                                        }
                                        Console.WriteLine("==============================================");
                                        Console.WriteLine("Presione cualquier tecla para Continuar.");
                                        Console.ReadKey();
                                    } while (eleccion8 != 0);
                                    break;
                                default:
                                    Console.WriteLine("Error: Ingrese un valor valido");
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("Presione cualquier tecla para Continuar.");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (eleccion2 !=0);

                        break;
                    case 2:
                        int eleccion1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("App de Celular\nQue desea hacer(Ingrese el numero)?" +
                            "\n1.Cuentas de ahorro: Consulta balance" +
                            "\n2.Prestamos: Pago de prestamos" +
                            "\n3.Certificados Financieros: Consulta de interes " +
                            "\n\n=======================================================" +
                            "\n0.menu anterior");
                            eleccion1 = Convert.ToInt32(Console.ReadLine());
                            switch (eleccion1)
                            {
                                case 0:
                                    break;
                                case 1:
                                    fachada.CuentaDeAhorro();
                                    break;
                                case 2:
                                    fachada.Prestamo();
                                    break;
                                case 3:
                                    fachada.Certificados();
                                    break;

                                default:
                                    Console.WriteLine("Error: Ingrese un valor valido");
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("Presione cualquier tecla para Continuar.");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (eleccion1 != 0);
                        break;

                    default:
                        Console.WriteLine("Error: Ingrese un valor valido");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Presione cualquier tecla para Continuar.");
                        Console.ReadKey();

                        break;
                }
            } while (eleccion !=0);
            Console.Clear();
            
            Console.WriteLine("==============================================");
            Console.WriteLine("Presione cualquier tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
