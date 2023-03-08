/*
 *  Pouvoir effectuer une soustraction.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 */

Console.WriteLine("Effectuer une division entière: ");

var isParse = int.TryParse(Console.ReadLine(), out var a);

if (isParse)
{
    Console.Write("Divisé par ");

    isParse = int.TryParse(Console.ReadLine(), out var b);

    if (isParse)
    {
        Console.Write("= ");

        if (b == 0)
        {
            Console.WriteLine("Vous ne pouvez pas effectuer une division par 0");
        }
        else
        {
            Console.Write(a / b);
        }
    }
    else
    {
        Console.WriteLine("Vous n'avez pas introduit un entier");
    }
}
else
{
    Console.WriteLine("Vous n'avez pas introduit un entier");
}
