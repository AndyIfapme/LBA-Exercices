/*
 *  Pouvoir effectuer une soustraction.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 */

Console.WriteLine("Effectuer une division entière : ");

var a = Convert.ToInt32(Console.ReadLine());
Console.Write("Divisé par ");

var b = Convert.ToInt32(Console.ReadLine());
Console.Write("= ");


if (b == 0)
{
    Console.WriteLine("Vous ne pouvez pas effectuer une division par 0");
}
else
{
    Console.Write(a / b);
}
