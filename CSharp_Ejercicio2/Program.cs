//Pedir al usuario que ingrese 2 y decir cual es el mayo al usuario
Console.WriteLine("Ingrese el primer número:");
int numero4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int numero5 = Convert.ToInt32(Console.ReadLine());

if (numero4 > numero5)
{
    Console.WriteLine("El número " + numero4 + " es mayor que " + numero5);
}
else if (numero5 > numero4)
{
    Console.WriteLine("El número " + numero5 + " es mayor que " + numero4);
}
else
{
    Console.WriteLine("Los números son iguales.");
}