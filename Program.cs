// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

/*int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);*/


/*EJERCICIO 1:*/

Console.WriteLine("Escriba un numero:");
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
}