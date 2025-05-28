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
/*while (true)
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
}*/


//EJERCICIO 3:
/*while (true)
{
    Console.WriteLine("----------CALCULADORA AVANZADA----------");
    Console.WriteLine("1. Calcular valor absoluto");
    Console.WriteLine("2. Calcular cuadrado");
    Console.WriteLine("3. Calcular raiz cuadrada");
    Console.WriteLine("4. Calcular seno");
    Console.WriteLine("5. Calcular coseno");
    Console.WriteLine("6. Calcular parte entera de un real");
    Console.WriteLine("7. Calcular max y min de dos numeros");
    Console.WriteLine("Seleccione una opcion:");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("VALOR ABSOLUTO");
            Console.WriteLine("Ingrese un numero:");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                num = -num;
            }
            else
            {
                Console.WriteLine("El numero ya es positivo");
            }
            Console.WriteLine("El valor absoluto es: " + num);
            break;
        case 2:
            Console.WriteLine("CUADRADO");
            Console.WriteLine("Ingrese un numero:");
            int num2 = int.Parse(Console.ReadLine());
            int cuadrado = num2 * num2;
            Console.WriteLine("El cuadrado del numero es: " + cuadrado);
            break;

        case 3:
            Console.WriteLine("RAIZ CUADRADA");
            Console.WriteLine("Ingrese un numero:");
            double num3 = double.Parse(Console.ReadLine());
            if (num3 >= 0)
            {
                double raizCuadrada = Math.Sqrt(num3);
                Console.WriteLine("La raiz cuadrada es: " + raizCuadrada);
            }
            else
            {
                Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
            }
            break;

        case 4:
            Console.WriteLine("SENO");
            Console.WriteLine("Ingrese un angulo en grados:");
            double angulo = double.Parse(Console.ReadLine());
            double anguloEnRadianes = angulo * (Math.PI / 180);
            double seno = Math.Sin(anguloEnRadianes);
            Console.WriteLine("El seno del angulo es: " + seno);
            break;

        case 5:
            Console.WriteLine("COSENO");
            Console.WriteLine("Ingrese un angulo en grados:");
            double angulo2 = double.Parse(Console.ReadLine());
            double anguloEnRadianes2 = angulo2 * (Math.PI / 180);
            double coseno = Math.Cos(anguloEnRadianes2);
            Console.WriteLine("El coseno del angulo es: " + coseno);
            break;

        case 6:
            Console.WriteLine("PARTE ENTERA DE UN REAL");
            Console.WriteLine("Ingrese un numero real:");
            double numReal = double.Parse(Console.ReadLine());
            int parteEntera = (int)numReal;
            Console.WriteLine("La parte entera es: " + parteEntera);
            break;

        case 7:
            Console.WriteLine("MAXIMO Y MINIMO DE DOS NUMEROS");
            Console.WriteLine("Ingrese el primer numero:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num5 = int.Parse(Console.ReadLine());
            int maximo = Math.Max(num4, num5);
            int minimo = Math.Min(num4, num5);
            Console.WriteLine("El maximo es: " + maximo);
            Console.WriteLine("El minimo es: " + minimo);
            break;

        default:
            Console.WriteLine("Opcion no valida, intente de nuevo");
            break;
    }

    if (opcion != 8)
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

}*/


//EJERCICIO 4:
Console.WriteLine("----------CADENA DE CARACTERES SU LONGITUD----------");
Console.WriteLine("Ingrese cadena de texto:");
string cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine("La longitud de la cadena es: " + longitud);

Console.WriteLine("----------CADENA DE CARACTERES CONCATENADA----------");
Console.WriteLine("Ingrese un segunda cadena de texto:");
string cadena2 = Console.ReadLine();
string mensajeCompleto = string.Concat(cadena, cadena2, ".");
Console.WriteLine("Texto concatenado: " + mensajeCompleto);

Console.WriteLine("----------CADENA DE CARACTERES EXTRAER UNA SUBCADENA----------");
Console.WriteLine("Ingrese la posicion inicial de la subcadena:");
int posicionInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());
if (posicionInicial >= 0 && posicionInicial < cadena.Length && longitudSubcadena > 0 && posicionInicial + longitudSubcadena <= cadena.Length)
{
    string subcadena = cadena.Substring(posicionInicial, longitudSubcadena);
    Console.WriteLine("Subcadena extraida: " + subcadena);
}
else
{
    Console.WriteLine("Posicion inicial o longitud de subcadena no valido");
}

while (true)
{
    Console.WriteLine("----------CALCULADORA BASICA CON RESULTADO EN TEXTO----------");
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
            string sumaCadena = suma.ToString();
            Console.WriteLine("La suma como cadena es: " + sumaCadena);
            break;
        case 2:
            Console.WriteLine("RESTAR");
            Console.WriteLine("Ingrese el primer numero:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num4 = int.Parse(Console.ReadLine());
            int resta = num3 - num4;
            Console.WriteLine("La resta es: " + resta);
            string restaCadena = resta.ToString();
            Console.WriteLine("La resta como cadena es: " + restaCadena);
            break;
        case 3:
            Console.WriteLine("MULTIPLICAR");
            Console.WriteLine("Ingrese el primer numero:");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int num6 = int.Parse(Console.ReadLine());
            int multiplicacion = num5 * num6;
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            string multiplicacionCadena = multiplicacion.ToString();
            Console.WriteLine("La multiplicacion como cadena es: " + multiplicacionCadena);
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
                string divisionCadena = division.ToString();
                Console.WriteLine("La division como cadena es: " + divisionCadena);
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

Console.WriteLine("----------CADENA DE CARACTERES MOSTRANDO CADA UNO DE SUS ELEMENTOS----------");
Console.WriteLine("Recorriendo la cadena de texto:");
foreach (char c in cadena)
{
    Console.WriteLine(c);
}

Console.WriteLine("----------CADENA DE CARACTERES MOSTRANDO PALABRA CLAVE----------");
Console.WriteLine("Ingrese una palabra a buscar en la cadena:");
string palabra = Console.ReadLine();
if (cadena.Contains(palabra))
{
    Console.WriteLine("La palabra " + palabra + " se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra " + palabra + " no se encuentra en la cadena.");
}

Console.WriteLine("----------CADENA DE CARACTERES MOSTRANDOLA EN MAYUSCULA Y MINUSCULA----------");
string cadenaMayusculas = cadena.ToUpper();
string cadenaMinusculas = cadena.ToLower();
Console.WriteLine("Cadena en mayusculas: " + cadenaMayusculas);
Console.WriteLine("Cadena en minusculas: " + cadenaMinusculas);

Console.WriteLine("----------CADENA DE CARACTERES SEPARADA POR UNA LETRA----------");
Console.WriteLine("Ingrese una tercera cadena de texto:");
string cadena3 = Console.ReadLine();
Console.WriteLine("Ingrese el caracter separador:");
char separador = Console.ReadKey().KeyChar;
Console.WriteLine();
string[] partes = cadena3.Split(separador);
Console.WriteLine("Partes de la cadena separadas por '" + separador + "':");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

while (true)
{
    Console.WriteLine("----------CALCULADORA DE ECUACIONES BASICAS----------");
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
            Console.WriteLine("Ingrese una ecuacion de la forma 'a + b':");
            string ecuacionSuma = Console.ReadLine();
            string[] parteSuma = ecuacionSuma.Split('+');
            if (parteSuma.Length == 2)
            {
                int num1 = int.Parse(parteSuma[0].Trim());
                int num2 = int.Parse(parteSuma[1].Trim());
                int suma = num1 + num2;
                Console.WriteLine("La suma es: " + suma);
            }
            else
            {
                Console.WriteLine("Ecuacion no valida, debe ser de la forma 'a + b'");
            }
            break;
        case 2:
            Console.WriteLine("RESTAR");
            Console.WriteLine("Ingrese una ecuacion de la forma 'a - b':");
            string ecuacionResta = Console.ReadLine();
            string[] parteResta = ecuacionResta.Split('-');
            if (parteResta.Length == 2)
            {
                int num1 = int.Parse(parteResta[0].Trim());
                int num2 = int.Parse(parteResta[1].Trim());
                int resta = num1 - num2;
                Console.WriteLine("La resta es: " + resta);
            }
            else
            {
                Console.WriteLine("Ecuacion no valida, debe ser de la forma 'a - b'");
            }
            break;
        case 3:
            Console.WriteLine("MULTIPLICAR");
            Console.WriteLine("Ingrese una ecuacion de la forma 'a * b':");
            string ecuacionMultipli = Console.ReadLine();
            string[] parteMultipli = ecuacionMultipli.Split('*');
            if (parteMultipli.Length == 2)
            {
                int num1 = int.Parse(parteMultipli[0].Trim());
                int num2 = int.Parse(parteMultipli[1].Trim());
                int multipli = num1 * num2;
                Console.WriteLine("La multiplicacion es: " + multipli);
            }
            else
            {
                Console.WriteLine("Ecuacion no valida, debe ser de la forma 'a * b'");
            }
            break;
        case 4:
            Console.WriteLine("DIVIDIR");
            Console.WriteLine("Ingrese una ecuacion de la forma 'a / b':");
            string ecuacionDividir = Console.ReadLine();
            string[] parteDividir = ecuacionDividir.Split('/');
            if (parteDividir.Length == 2)
            {
                int num1 = int.Parse(parteDividir[0].Trim());
                int num2 = int.Parse(parteDividir[1].Trim());
                if (num2 != 0)
                {
                    double division = (double)num1 / num2;
                    Console.WriteLine("La division es: " + division);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero");
                }
            }
            else
            {
                Console.WriteLine("Ecuacion no valida, debe ser de la forma 'a / b'");
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