
float a = 0;
float b = 0;

Console.WriteLine("Calculadora en C#");
Console.WriteLine("\n");

Console.WriteLine("Escribe tú primer número: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe el segundo número: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Que operacion matematica quieres hacer?:");
Console.WriteLine("R: Restar - S: Sumar - M: Multiplicar - D: Dividir\n");
Console.WriteLine("Cuál es tu opcion: ");
switch (Console.ReadLine())
{
    case "S":
        Console.WriteLine($"El resultado de la suma {a} + {b} = " + (a + b));
        break;
    case "R":
        Console.WriteLine($"El resultado de la resta {a} - {b} = " + (a - b));
        break;
    case "N":
        Console.WriteLine($"El resultado de la multiplicación {a} * {b} = " + (a * b));
        break;
    case "D": 
        while(b == 0)
        {
            Console.WriteLine("No se puede dividir por 0, elige un divisor diferente: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"El resultado de la division {a} / {b} = " + (a / b));
        break;
}

Console.ReadKey();