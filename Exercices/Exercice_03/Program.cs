/*
 *  Pouvoir effectuer une soustraction.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 *
 *  On propose à l'utilisateur de recommancer tant qu'il n'introduit pas des valeurs entières
 */

Console.WriteLine("Effectuer une division entière: ");

bool isParse;
int a, b;

do
{
    Console.Write("Votre nombre : ");
    isParse = int.TryParse(Console.ReadLine(), out a);

    if (!isParse)
    {
        Console.WriteLine("Vous n'avez pas introduit un entier");
    }

} while (!isParse);

do
{
    Console.Write("Divisé par ");
    isParse = int.TryParse(Console.ReadLine(), out b);

    if (!isParse)
    {
        Console.WriteLine("Vous n'avez pas introduit un entier");
    }
    else if (b == 0)
    {
        Console.WriteLine("Vous ne pouvez pas effectuer une division par 0");
    }

} while (!isParse || b == 0);

Console.Write($" {a} / {b} = {a / b}");