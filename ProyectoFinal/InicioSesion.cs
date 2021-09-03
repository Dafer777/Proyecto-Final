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
        public static void Inicio()
        {
            int i = 0;
            //usuario nivel 1 ADMIN
            Console.WriteLine("Ingrese el usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            string contraseña = Console.ReadLine();

            if ((usuario == "admin") && (contraseña == "123"))
            {
                i = 5;
                Console.WriteLine("Ha ingresado exitosamente");
            }
            else if (i > 3)


                Console.WriteLine("El numero de intento a sido alcanzado.");
  


            else
            {
                Console.WriteLine("El nombre de usuario o contraseña son incorrctos");
                i++;


                //usuario nivel 2

                // el acceso de usuario nivel 2 lo tienes que crear tu Gabriel
                Console.WriteLine("Ingrese el usuario");

                Console.ReadKey();
           
            }

        }



    }
}
