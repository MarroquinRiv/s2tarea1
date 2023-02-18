byte edad, n1, n2;
ushort prod;
long nl1, nl2, sum, res, prodl;

try
{
    Console.Write("Primero. ¿Qué edad tienes? ");
    edad = (byte)Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Wow, no aparentas {edad} años.");

    Console.Write("\nAhora necesito dos números de dos cifras para mostrarte algo: \n\n");
    n1 = (byte)Convert.ToInt32(Console.ReadLine());
    n2 = (byte)Convert.ToInt32(Console.ReadLine());
    prod = (ushort)(n1 * n2);
    Console.WriteLine($"\nCalculé el producto de la multiplicación de ambos números, es: {prod}");

    Console.Write("\nPor último, ingresa dos números enteros largos: \n\n");
    nl1 = (long)Convert.ToInt32(Console.ReadLine());
    nl2 = (long)Convert.ToInt32(Console.ReadLine());
    sum = (nl1 + nl2);
    res = (nl1 - nl2);
    prodl = (nl1 * nl2);
    Console.WriteLine($"\nEl resultado de la suma de ambos números es: {sum}");
    Console.WriteLine($"La diferencia de ambos números es: {res}");
    Console.WriteLine($"Y el producto de la multiplicación de ambos números es: {prodl}");
}
catch (Exception ex)
{
    Console.WriteLine("Ups, no me entendiste. Prueba ingresar solo números enteros o, tal vez te excediste con la longitud del número. :/");
    Console.Write("La excepción es: " + ex.Message);
}