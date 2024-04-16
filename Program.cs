using System;
class Program
{
    static void Main(string[] args)
    {
        //Variables de uso para ciclos y validaciones
        Boolean validacion = true;

        //Variables de uso del cliente
        string userlogin = "";
        string passwordLogin = "";
        string TCuenta = "";
        string nombreP = "";
        string dpi = "";
        string direccion = "";
        string telefono = "";
        double saldo = 2500.00;
        string user = "a";
        string password = "1";

        /* Inicializamos i = 0, validamos que i == 0 para que se cumple el ciclo,
        si no es valida la informacion enotonces i = 0 (Se repite el ciclo),
        si es valida la infomacion enotonces i = 1 (No se cumple el ciclo)
        por lo tanto se sale del ciclo */
        for (int i = 0; i == 0;)
        {
            // Solicitamos la informacion del usuario y contraseña
            Console.WriteLine("\n*-----------------LOG IN-------------------*");
            Console.WriteLine("Ingrese su usuario: ");
            userlogin = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            passwordLogin = Console.ReadLine();

            // Validamos que sea correcto el ususario y contraseña
            if (userlogin == user && passwordLogin == password)
            {
                Console.WriteLine("\n*------------------------------------*");
                Console.WriteLine("Ingrese su nombre completo:");
                nombreP = Console.ReadLine();
                Console.WriteLine($"\nBIENVENIDO! {nombreP}\n");
                i = 1;
            }
            else
            {
                Console.WriteLine("El usuario o contraseña es incorrecta.");
                Console.ReadKey();
                i = 0;
            }
        }

        /* Inicializamos i = 1, validamos que i == 1 para que se cumple el ciclo,
        si el usuario escoge una opcion no valida enotonces i = 1 (Se repite el ciclo),
        si el usuario escoge el tipo de cuenta ahorro o monetaria enotonces i = 0 (No se cumple el ciclo)
        por lo tanto se sale del ciclo */
        for (int i = 1; i == 1;)
        {

            // Solicitar el tipo de cuenta (Ahorro o Monetaria)
            Console.WriteLine("\n*------------------------------------*");
            Console.WriteLine("Ingrese su tipo de cuenta:");
            Console.WriteLine("1. Ahorro\n2. Monetaria");
            char opcion1 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Validamos el tipo de cuenta
            switch (opcion1)
            {
                case '1':
                    {
                        TCuenta = "Ahorro";
                        i = 0;
                        break;
                    }
                case '2':
                    {
                        TCuenta = "Monetaria";
                        i = 0;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nLa opcion que escogio es invalida");
                        i = 1;
                        break;
                    }
            }

        }

        /* Inicializamos i = 0, validamos que i == 0 para que se cumple el ciclo,
        si no es valida la informacion enotonces i = 0 (Se repite el ciclo),
        si es valida la infomacion enotonces i = 1 (No se cumple el ciclo)
        por lo tanto se sale del ciclo */
        for (int i = 0; i == 0;)
        {

            //Solicitamos DPI del usuario
            Console.WriteLine("\nIngrese su DPI (documento Personal de Identificacion):");
            dpi = Console.ReadLine();

            //Validamos la cantidad numerica del DPI del usuario
            if (dpi.Length == 13)
            {

                Console.WriteLine("Ingrese su direccion:");
                direccion = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de telefono:");
                telefono = Console.ReadLine();
                i = 1;

            }
            else
            {
                Console.WriteLine("\nEl documento de identificacion personal es invalido");
                i = 0;
            }

        }

        /* Inicializamos la variable "validacion" con "true" de tipo booleano entonces para cualquier accion (validacion = true),
        excepto "Finalizacion del programa" (Validacion = false) por lo tanto no se cumple el ciclo (Finalizacion del programa) */
        do
        {

            //Solicitamos al usuario el tipo de accion que quiere realizar
            Console.WriteLine("\n*");
            Console.WriteLine("\n*-------------------MENU---------------------*\n");
            Console.WriteLine("Ingrese la opcion segun sea su necesidad\n");
            Console.WriteLine("1.Ver informacion de la cuenta.\n2.Comprar producto financiero.\n3.Vender producto financiero\n4.Abonar a cuenta.\n5.Simular paso del tiempo.\n6.Salir.\n");
            Console.Write("Ingrese una opcion: \n");
            char opcion2 = Console.ReadKey().KeyChar;

            //Validmaos la accion que quiere realizar el usuario
            switch (opcion2)
            {
                case '1':
                    {

                        //Mostramos la informacion de cuenta del usuario
                        Console.WriteLine("\n*---------------INFORMACION DE LA CUENTA--------------*\n");
                        Console.WriteLine("\nSu tipo de cuenta es: " + TCuenta);
                        Console.WriteLine("Nombre de Cuenta: " + nombreP);
                        Console.WriteLine("Numero de DPI: " + dpi);
                        Console.WriteLine("Direccion: " + direccion);
                        Console.WriteLine("Numero de telefono: " + telefono);
                        Console.WriteLine("El saldo de la Cuenta es: " + saldo);
                        Console.WriteLine("\nPresiona Enter para continuar.");
                        break;

                    }
                case '2':
                    {

                        //Realizamos la compra de un producto financiero 
                        Console.WriteLine("\n*--------------COMPRA DE PRODUCTO FINANCIERO------------*\n");
                        Console.WriteLine("Usted realizo una compra de un producto financiero!");
                        saldo = saldo - (saldo * 0.10);
                        Console.WriteLine($"Su saldo actual es de: Q{saldo}");

                        Console.WriteLine("\nPresiona Enter para continuar.");
                        break;
                    }
                case '3':
                    {

                        //Validamos que el saldo sea mayor a Q500
                        if (saldo > 500)
                        {

                            //Realizamos la venta de un producto financiero
                            saldo = saldo + (saldo * 0.11);
                            Console.WriteLine("\n*------------VENTA DE PRODUCTO FINANCIERO-------------*\n");
                            Console.WriteLine("Usted realizo una venta de un producto financiero!");
                            Console.WriteLine($"Su saldo actual es de: Q{saldo}");
                            Console.WriteLine("\nPresiona Enter para continuar.");

                        }
                        else
                        {

                            //Si no se cumplen los criterios del saldo se muestran mensajes
                            Console.WriteLine("No puede realizar esta accion debido a que su saldo es menor a Q500");
                            Console.WriteLine("\nPresiona Enter para continuar.");

                        }
                        break;
                    }
                case '4':
                    {
                        
                        /* Inicializamos i = 0, validamos que i <= 1 para que se cumple el ciclo,
                        si el usuario escoge Si en ABONAR CUENTA enotonces i++ (Se repite el ciclo),
                        si el usuario escoge de nuevo en ABONAR CUENTA entonces 1++ (i va ser 2) por lo tanto se rompe el ciclo,
                        si el usuario escoge No en ABONAR CUENTA enotonces i = 2 (No se cumple el ciclo) por lo tanto se sale del ciclo,
                        si el usuario no cumple con los criterios entonces se repite el ciclo */
                        for (int i = 0; i <= 1;)
                        {

                            //Solicitamos si quiere abonar a una cuenta
                            Console.WriteLine("");
                            Console.WriteLine("\n*------------ABONAR CUENTA-------------*\n");
                            Console.WriteLine("¿Desea abonar?");
                            Console.WriteLine("1.Si\n2.No");
                            char opcion3 = Console.ReadKey().KeyChar;

                            //Validamos la accion que quiere realizar el usuario
                            switch (opcion3)
                            {
                                case '1':
                                    {

                                        //Validamos que el saldo sea mayor a Q500
                                        if (saldo > 500)
                                        {

                                            //Abonamos a la cuenta del usuario
                                            saldo = saldo * 2;
                                            Console.WriteLine("");
                                            Console.WriteLine($"Su saldo actual es de Q{saldo}");
                                            i++;
                                            Console.WriteLine("\nPresiona Enter para continuar.");

                                        }
                                        else
                                        {

                                            //Si no se cumplen los criterios del saldo se muestran mensajes
                                            Console.WriteLine("\nNo puede realizar esta accion debido a que su saldo es menor a Q500");
                                            Console.WriteLine("\nPresiona Enter para continuar.");

                                        }
                                        break;
                                    }
                                case '2':
                                    {

                                        //Se finaliza la accion de Abono
                                        i = 2;
                                        break;

                                    }
                                default:
                                    {

                                        //Si no se cumplen los criterios de la accion que quiere realizar el usuario se muestran mensajes
                                        Console.WriteLine("\nLa opcion que usted realizo no es valida");
                                        Console.WriteLine("\nPresiona Enter para continuar.");
                                        break;

                                    }
                            }
                        }
                        break;
                    }
                case '5':
                    {

                        //Solicitamos el periodo de capitalizacion (Una vez al mes o dos veces al mes)
                        Console.WriteLine("\n*------------PERIODO DE CAPITALIZACION------------*\n");
                        Console.WriteLine("Ingrese el periodo de capitalizacion");
                        Console.WriteLine("1.Una vez al mes\n2.Dos veces al mes");
                        char opcion3 = Console.ReadKey().KeyChar;

                        //Validamos la accion que desea realizar el usuario 
                        switch (opcion3)
                        {
                            case '1':
                                {

                                    //Realizamos la accion de capitalizacion (Una vez al mes)
                                    Console.WriteLine("\n-----------------------------------------");
                                    saldo = saldo + (saldo * 0.02);
                                    Console.WriteLine($"Su saldo actual por el interes de 1 mes es de: Q{saldo}");
                                    Console.WriteLine("\nPresiona Enter para continuar.");
                                    break;
                                }
                            case '2':
                                {

                                    //Realizamos la accion de capitalizacion (Dos veces al mes)
                                    Console.WriteLine("\n-----------------------------------------");
                                    saldo = saldo + (saldo * 2);
                                    Console.WriteLine($"Su saldo actual por el interes de 2 meses es de: Q{saldo}");
                                    Console.WriteLine("\nPresiona Enter para continuar.");
                                    break;
                                }
                            default:
                                {

                                    //Si no se cumplen los criterios de la accion que quiere realizar el usuario se muestran mensajes
                                    Console.WriteLine("\n-----------------------------------------");
                                    Console.WriteLine("La opcion que usted realizo no es valida");
                                    Console.WriteLine("\nPresiona Enter para continuar.");
                                    break;

                                }
                        }
                        break;
                    }
                case '6':
                    {

                        //Finalizacion del programa
                        Console.WriteLine("\n-----------------FELIZ DIA------------------\n");
                        validacion = false;
                        break;

                    }
                default:
                    {

                        //Si no se cumplen los criterios de la accion que quiere realizar el usuario se muestran mensajes
                        Console.WriteLine("");
                        Console.WriteLine("La opcion que ingreso es invalida porfavor intentelo de nuevo!\n");
                        Console.WriteLine("\nPresiona Enter para continuar.");
                        break;

                    }
            }
            Console.ReadKey();
        } while (validacion);
        
    }
}