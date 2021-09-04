using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProyectoFinal
{
    class InicioSesion
    {
        //FALTA TERMINAR
        public static void Inicio()
        {
            int i = 0;
            //usuario nivel 1 ADMIN
          


            while (i<3)
            {
                Console.WriteLine("Ingrese el usuario");
                string usuario = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña");
                string contraseña = Console.ReadLine();
                i++;


                if ((usuario == "admin") && (contraseña == "123"))
                {
                    i = 4;
                    Console.WriteLine("Ha ingresado exitosamente");
                   

                }
                else
                {
                    Console.WriteLine("El nombre de usuario o contraseña son incorrctos");
                   
                    if (i == 3)
                    {
                       
                        Console.WriteLine("Has excedido el numero de intentos");
                        Environment.Exit(2);


                    }

                }
            }
           

            






            Console.ReadKey();
           
            

        }



    }
}
