using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoFinal;

namespace ProyectoFinal
{
    class Program
    {

        //David Fernandez
        static void Main()
        {

            InicioSesion.Inicio();
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = Menu(); //llamado al metodo Menu()
            }
            Console.ReadKey();
        }




        private static bool Menu()
        {
            //USUARIO ADMIN
            Console.Write("Nombre del usuario: ");
            string name = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();


            int i = 0;

            if ((name == "admin") && (contraseña == "123"))
            {
                Console.WriteLine("Ha ingresado exitosamente");
                i = 3;
            }

            //crear el menu para mostrar al usuario
            //Console.Clear(); //permite limpiar la consola
            Console.WriteLine("Seleccion la operación a realizar: ");
            Console.WriteLine("1. Registrar nuevo usuario");
            Console.WriteLine("2. borrar archivo");
            Console.WriteLine("4. Mostrar archivo");
            Console.WriteLine("5. Salir");
            Console.Write("\nOpcion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    register(); //llamado al metodo registrar
                    return true;
                case "2":
                    
                case "3":
                  
                    return true;
                case "4":
                    return false;
                default:
                    return false;
            }
        }




        //metodo para obtener la ruta del archivo
        private static string getPath()
        {
            string path = @"D:\ejemplo\registros.txt";
            return path;
        }

        //metodo para registrar datos en el archivo
        private static void register()
        {
            //solicitar los datos para registar al usuario
            Console.WriteLine("DATOS USUARIO");
            Console.Write("Nombre del usuario: ");
            string name = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();

            //crear el archivo, uso de StreamWriter para escribir el archivo
            using (StreamWriter sw = File.AppendText(getPath()))
            {
                sw.WriteLine("{0}; {1}", name, contraseña);
                sw.Close();
            }
        }
        //David Fernandez

    }
}
