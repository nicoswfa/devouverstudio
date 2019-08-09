using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args) //Clase 1

        /*string = texto, 
         * byte = enteros sin signo, 
         * int/short/long (normal, 32bits, 64bits) = números enteros con signo, 
         * bool = si/no etc, 
         * float = decimal, 
         * var = variable implícita (siempre tiene que inicializarse al declararla)
         * char = una letra (carácter)
         */
        {
            Console.WriteLine("Hola Mundo!"); //Cuando NOSOTROS queremos mostrarle texto al usuario
            Console.WriteLine("¿Qué nombre quieres ponerme?");
            string Nombre = Console.ReadLine();      //Console.ReadLine, cuando el usuario debe brindar información al programa             
            Console.WriteLine("¿Soy hombre o mujer?");
            string Sexo = Console.ReadLine();
            Console.WriteLine("¿Y dime, cuántos años tengo?");
            int Edad1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Oh, entonces mi nombre es {0}, soy {1}, y tengo {2}...", Nombre, Sexo, Edad1);


            Console.WriteLine("¿Cómo es tu nombre?");
            var TuNombre = Console.ReadLine();
            Console.WriteLine("Bienvenido, {0}", TuNombre);
            Console.WriteLine("¿Que edad tienes?");
            var Edad2 = Convert.ToInt32(Console.ReadLine()); //Convert.To cuando hay que convertir una variable de un tipo a otro
            Console.WriteLine("Con que tienes {0}...", Edad2);

            Console.WriteLine("Por cierto, ya dije que tengo {0}?", Edad1);

            const double PI = 3.14; //const cuando hay que declarar un dato constante que no cambiar durante la ejecución del programa

            Console.WriteLine("Entonces, nuestras edades suman {0}...", Edad1 + Edad2);

            Edad2++; //Cambia PERMANENTEMENTE un dato (en este caso, suma 1, para restar es "X--")
                     //Prefijo = ++X/--X, esto PRIMERO resuelve y después asigna. Sufijo = X++/X-- PRIMERO asigna y después resuelve.

            Console.WriteLine("Luego de un año, tu edad será {0}", Edad2);
            Console.WriteLine("¿Cómo te sientes sabiendo que tendrás {0} el próximo año? No importa...", Edad2);
            Console.WriteLine("Cómo estás?");
            string Estado = Console.ReadLine();

            if (Estado == "Bien")                                 //if, cuando el valor es verdadero, se aplica X código
            {
                Console.WriteLine("Bien ahí perrito");
            }
            else                                                  //else if, cuando queremos aplicar código a otra respuesta ESPECIFICA que no sea el primer if
            if (Estado == "Mal")
            { 
                Console.WriteLine("¿Qué paso?");                  
                }
             else                                                 //else, cuando el valor es falso, se aplica Y código
            {
                Console.WriteLine("¿Cómo?");
                    }
  
                
                Console.Read();
            


       



            
        }
    }
}
