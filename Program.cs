using System;

public class CalculadoraMRU_MRUA
{
    public static void Main(string[] args)
    {
        int yes = 1;
        while (yes == 1)//con el while podra correr de nuevo el codigo siempre y caudno el usuario quiera.
        {
            int mru = 1;
            int mrua = 2; //agrego dos variables para realizar un condicional if , else if.
        
            Console.WriteLine("Hola, como estas?");
            Console.WriteLine("Bienvenido a la Calculadora de MRU y MRUA\n");
        
            Console.WriteLine("Que desea realizar?");
            Console.WriteLine("Seleccione la formula que desea ocupar:\n");
            Console.WriteLine("1.- Calcular en MRU");
            Console.WriteLine("2.- Calcular en MRUA\n");
            Console.WriteLine("Por favor, seleccione un numero para realizar su operacion:");
        
            int option = Convert.ToInt32(Console.ReadLine());
        
            if(option == mru)//en caso que el usuario elija la opcion numero uno con esa condicion se correra el codigo.
            {//aqui presente el menu que le mostrara al usuario.
                Console.WriteLine("Excelente ha seleccionado:\n");
                Console.WriteLine("Calcular en MRU");
                Console.WriteLine("Seleccione la operacion que desea realizar:");
                Console.WriteLine("1.- Calcular la distancia (d = v * t)");
                Console.WriteLine("2.- Calcular la velocidad (v = d / t)");
                Console.WriteLine("3.- Calcular el tiempo    (t = d / v)\n");
                Console.WriteLine("Por favor, seleccione un numero para realizar su operacion:");
            
                int operation = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero por favor:");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero por favor:");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;
                switch (operation) // un swich similar al if pero es mas directo no combeniente 
                {
                    case 1: // hay tres opciones que podra escojer el usuario seguido de la ejecuison del la operacion.
                        resultado = n1 * n2;
                        Console.WriteLine($"La distancia es: {resultado}");
                        break;
                    case 2:
                        resultado = n1 / n2;
                        Console.WriteLine($"La velocidad es: {resultado}");
                        break;
                    case 3:
                        resultado = n1 / n2;
                        Console.WriteLine($"El tiempo es: {resultado}");
                        break;
                }
            }
            else if(option == mrua)// En caso de elijir la opcion del primer menu se correra este codigo con un else if.
            {//Al correr este codigo el menu siguiete se mostrara en pantalla dando conoser al usuario las siguientes opciones.
                Console.WriteLine("Excelente ha seleccionado:\n");
                Console.WriteLine("Calcular en MRUA\n");
                Console.WriteLine("Seleccione la operacion que desea realizar:");
                Console.WriteLine("4.- Calcular la posicion final   (x = x0 + v0 * t + 0.5 * a * t^2)");
                Console.WriteLine("5.- Calcular la velocidad final  (v = v0 + a * t)");
                Console.WriteLine("6.- Calcular el tiempo           (t = (v - v0) / a)\n");
                Console.WriteLine("Por favor, seleccione un numero para realizar su operacion:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 4)//  En esta parte del codiago es espesacial por que la opcion 4 tiene 6 caracteristicas para realiazar la operacion.
                {
                    Console.WriteLine("Ingrese el numero de posicion inial = x0:");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el numero de velocidad inial = v0:");
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el numero de timpo = t:");
                    double n3 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Multiplica por  0.5:");
                    double n4 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el numero daceleracion = a:");
                    double n5 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el numero de timpo al cuarado = t^2:");
                    double n6 = Convert.ToDouble(Console.ReadLine());
                    
                    double resultado = n1 + n2 * n3 + n4 * n5 * n6;
                    Console.WriteLine($"La posicion final es: {resultado}");
                }
                else if (opcion == 5)// Un else if para el numero 5 que costa de 3 caracteristicas para realizar la oprecion.
                {
                    Console.WriteLine("Ingrese el primer numero:");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero:");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el tercer numero:");
                    double n3 = Convert.ToDouble(Console.ReadLine());

                    double resultado = n1 + n2 * n3;
                    Console.WriteLine($"La velocidad final es: {resultado}");
                }
                else if (opcion == 6)//Para la opcion 6 lo realize separado para guardar un orden y que pueda yo entender.
                {
                    Console.WriteLine("Ingrese el primer numero:");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero:");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el tercer numero:");
                    double n3 = Convert.ToDouble(Console.ReadLine());

                    double resultado = ( n1 - n2)  / n3;
                    Console.WriteLine($"El tiempo es: {resultado}");
                }
                
            }
            else // Si el usuario ingresa  un numero fuera de las opciones en el menu principal se le mostrara el siguinte mesage.
            {
                Console.WriteLine("Introduzca un munero dentro de las opciones  por favor.");
            }

            Console.WriteLine("Te gustaria seguir utilizando la calculadora? \n1.- Si\n2.- No");
            //SI el usuario requiera de usar la super calculadora nuevamnete el progra le preguntara el siguiente mensage.
            yes = Convert.ToInt32(Console.ReadLine());
            // Al concluir el progrma se muestra el siguiente mensage.
            Console.WriteLine("MUCHAS GRACIAS POR USAR LA SUPER CALCULADORA");
        }
    }
}
