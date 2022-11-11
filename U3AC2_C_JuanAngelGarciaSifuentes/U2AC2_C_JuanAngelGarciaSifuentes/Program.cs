using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace U2AC2_C_JuanAngelGarciaSifuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables 
            string nombre, usuario, email, contraseña, confirmarcontraseña,respuesta;
            string ciudad, datos, nacimiento, estado,respuesta2;
            int alto, ancho;



            //uso de las variables
            Console.WriteLine("EmMPEZAMOS CON EL PERFIL");
            Console.WriteLine("\n");

            Console.WriteLine("Poga su nommbre completo:");
            nombre = Console.ReadLine();

            Console.WriteLine("Escriba su fecha de nacimiento:");
            nacimiento = Console.ReadLine();
            
            Console.WriteLine("Escriba el estado en el que vive actualmente");
            estado = Console.ReadLine();

            Console.WriteLine("Escriba la ciudad en la que vive actualmente");
            ciudad = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("ES HORA DE REGISTRASE");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su correo email:");
            email = Console.ReadLine();

            Console.WriteLine("Por favor ingrese un usuario tambien");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña");
            contraseña = Console.ReadLine();

            Console.WriteLine("Por favor ingrese nuevamente su contraseña");
            confirmarcontraseña = Console.ReadLine();
            Console.WriteLine("\n");

            //aqui se usa el if
          
            if (contraseña == confirmarcontraseña)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Ahora inicie sesion");
                Console.WriteLine("Ingrese su usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Ahora ingrese su contraseña");
                datos = Console.ReadLine();
                Console.WriteLine("\n");

                if (confirmarcontraseña == datos)
                {
                    Console.WriteLine("Los datos del usuario son:");
                    Console.WriteLine("nombre: {0}", nombre);
                    Console.WriteLine("Fecha de nacimiento: {0}", nacimiento);
                    Console.WriteLine("Estado: {0}", estado);
                    Console.WriteLine("Ciudad: {0}", ciudad);
                    Console.WriteLine("correo email: {0}", email);

                }

                
            }
            else
            {
                Console.WriteLine("Te has equivcado en el usuario o en la contraseña por favor intenta nuevamente");
                Console.WriteLine("saliendo de sistema");
                Thread.Sleep(4000);
                return;
            }
            


           
            Console.WriteLine("Ahora puede configurar el como quiere que se vea la consola");
            Console.WriteLine("\n");

            Console.WriteLine("¿Que color de fondo quieres? (presiona el color  que desees)");
            Console.WriteLine("1-Rojo  2-Blanco  3-Verde ");
            respuesta = Console.ReadLine();
            
           //este if va referido a el color al fondo de la consola que se dara si lo selecciona 
            if (respuesta == "rojo")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("El fondo se ha cambiado correctamente \n");

            }
            else
            {
                    
            }
            if (respuesta == "blanco")// este iff igual va para el fonfo de la consola
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("El fondo se ha cambiado correctamente \n");

            }
            else
            {

            }    
            if (respuesta == "verde")//y este igualmente es el color de fondo de consola que se dara si es seleccionado
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine(" El fondo se ha cambiado correctamente \n");
            }


            Console.WriteLine("\n Los datos del usuario son:");// este lo copie para que se muestre en la consola de nuevo las 6 lineas siguentes y esata
            Console.WriteLine("nombre: {0}", nombre);
            Console.WriteLine("Fecha de nacimiento: {0}", nacimiento);
            Console.WriteLine("Estado: {0}", estado);
            Console.WriteLine("Ciudad: {0}", ciudad);
            Console.WriteLine("correo email: {0}", email);

            Console.WriteLine("\n ¿Que color de letra desea tener ? (presiona el color  que desees)");// este es para seleccionar el color de la letra
            Console.WriteLine("1-blanco  2-magenta  3-cyan ");
            respuesta2 = Console.ReadLine();
            if (respuesta2 == "blanco")//color que se dara a la letra
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("El color de la letra se ha cambiado correctamente \n");
            }
            else
            {

            }
            if (respuesta2 == "magenta")//color que se dara a la letra
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("El color de la letra se ha cambiado correctamente \n");
            }
            else
            {

            }
            if (respuesta2 == "cyan")//color que se dara a la letra
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("El color de la letra se ha cambiado correctamente \n");

            }
            Console.WriteLine("Los datos del usuario son:");
            Console.WriteLine("nombre: {0}", nombre);
            Console.WriteLine("Fecha de nacimiento: {0}", nacimiento);
            Console.WriteLine("Estado: {0}", estado);
            Console.WriteLine("Ciudad: {0}", ciudad);
            Console.WriteLine("correo email: {0}", email);

            Console.WriteLine("\n selecciona el alto que deseas");// este es el alto que se dara a la consola
            Console.WriteLine("1-40 2-20 3-30");
            alto = Convert.ToInt32( Console.ReadLine());

            if (alto == 40 )// es el ancho que se dara en la consola
            {
                Console.WindowHeight = 40;
                Console.Clear();
                Console.WriteLine("se ha cambiado correctamente la altura de la consola \n");
            }
            else
            {
                    
            }
            if (alto == 20)
            {
                Console.WindowHeight = 20;// es el ancho que se dara en la consola
                Console.Clear();
                Console.WriteLine("se ha cambiado correctamente la altura de la consola\n");
            }
            else
            {
                    
            }
            if (alto == 30)
            {
                Console.WindowHeight = 30;// es el ancho que se dara en la consola
                Console.Clear();
                Console.WriteLine("se ha cambiado correctamente la altura de la consola\n");
            }
            Console.WriteLine("Los datos del usuario son:"); ;// este lo copie para que se muestre en la consola de nuevo las 6 lineas siguentes y esata
            Console.WriteLine("nombre: {0}", nombre);
            Console.WriteLine("Fecha de nacimiento: {0}", nacimiento);
            Console.WriteLine("Estado: {0}", estado);
            Console.WriteLine("Ciudad: {0}", ciudad);
            Console.WriteLine("correo email: {0}", email);

            Console.WriteLine("\n selecoiona el ancho que deseas");// este es el ancho que se dara a la consola
            Console.WriteLine("1-100 2-50 3-75");
            ancho = Convert.ToInt32(Console.ReadLine());

            if (ancho == 100)// este es el ancho que se pondra a la consola
            {
                Console.WindowWidth = 100;
                Console.Clear();
                Console.WriteLine("se ha cambiado el ancho correctamente \n");
            }
            else
            {

            }
            if (ancho == 50)
            {
                Console.WindowWidth = 50;
                Console.Clear();
                Console.WriteLine(" se ha cambiado el ancho correctamente \n");
            }
            else
            {

            }
            if (ancho == 75)
            {
                Console.WindowWidth = 75;
                Console.Clear();
                Console.WriteLine("se ha cambiado el ancho correctamente \n");
            }

            Console.WriteLine("Los datos del usuario son:"); ;// este lo copie para que se muestre en la consola de nuevo las 6 lineas siguentes y esata
            Console.WriteLine("nombre: {0}", nombre);
            Console.WriteLine("Fecha de nacimiento: {0}", nacimiento);
            Console.WriteLine("Estado: {0}", estado);
            Console.WriteLine("Ciudad: {0}", ciudad);
            Console.WriteLine("correo email: {0}", email);

            Console.WriteLine("Ingrese el nombre que le quiuera poner a la consola:");
            Console.Title = Console.ReadLine();
            Console.WriteLine("\n se ha cambiado el titulo correctamente");


            Console.WriteLine("saliedno de la consola");
            Thread.Sleep(2000);
            Console.WriteLine("saliedno de la consola.");
            Thread.Sleep(2000);
            Console.WriteLine("saliedno de la consola..");
            Thread.Sleep(2000);
            Console.WriteLine("saliedno de la consola...");
            Thread.Sleep(2000);
            return;

            Console.ReadKey();

          

        }
    }
}
