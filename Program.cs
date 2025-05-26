// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

/*int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);*/


/*EJERCICIO 1:*/

/*Console.WriteLine("Escriba un numero:");
string numero = Console.ReadLine();
int num = 0;
bool esNumero = int.TryParse(numero, out num);
if (esNumero)
{
    if (num > 0)
    {
        char[] arr = numero.ToCharArray();
        Array.Reverse(arr);
        string numeroInvertido = new string(arr);
        Console.WriteLine("El numero invertido es: " + numeroInvertido);
    }
    else
    {
        Console.WriteLine("El numero no es mayor a 0");
    }
}
else
{
    Console.WriteLine("El texto ingresado no es un numero valido");
}*/


/*EJERCICIO 2:*/
while (true)
{
    Console.WriteLine("----------CALCULADORA BASICA----------");
    Console.WriteLine("1. Calcular suma");
    Console.WriteLine("2. Calcular resta");
    Console.WriteLine("3. Calcular multiplicacion");
    Console.WriteLine("4. Calcular division");
    Console.WriteLine("Seleccione una opcion:");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("SUMAR");
            Console.WriteLine("Ingrese el primer numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num2 = int.Parse(Console.ReadLine());
            int suma = num1 + num2;
            Console.WriteLine("La suma es: " + suma);
            break;
        case 2:
            Console.WriteLine("RESTAR");
            Console.WriteLine("Ingrese el primer numero:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num4 = int.Parse(Console.ReadLine());
            int resta = num3 - num4;
            Console.WriteLine("La resta es: " + resta);
            break;
        case 3:
            Console.WriteLine("MULTIPLICAR");
            Console.WriteLine("Ingrese el primer numero:");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num6 = int.Parse(Console.ReadLine());
            int multiplicacion = num5 * num6;
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            break;
        case 4:
            Console.WriteLine("DIVIDIR");
            Console.WriteLine("Ingrese el primer numero:");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num8 = int.Parse(Console.ReadLine());
            if (num8 != 0)
            {
                double division = (double)num7 / num8;
                Console.WriteLine("La division es: " + division);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            break;
        default:
            Console.WriteLine("Opcion no valida, intente de nuevo");
            break;
    }

    if (opcion != 5)
    {
        Console.WriteLine("Desea realizar otra operacion? (s/n):");
        string respuesta = Console.ReadLine();
        if (respuesta.ToLower() != "s")
        {
            Console.WriteLine("Saliendo...");
            break;
        }
        else
        {
            Console.WriteLine("Continuando...");
        }
    }
}