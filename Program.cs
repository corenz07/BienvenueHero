namespace bienvenue_hero;

/*
    CONSIGNES
    Vous développez un petit jeu de rôle (RPG). Lorsque le joueur commence une partie, son personnage doit afficher un message de bienvenue.
    1. Créez une méthode appelée AfficherBienvenue().
    2. Cette méthode doit afficher dans la console : "Bienvenue dans votre aventure, héros !".
    3. Appelez cette méthode depuis la méthode Main().
*/
class Program
{
     public static void AfficherBienvenue()
    {
        Console.WriteLine("Bienvenue dans votre aventure, héros !");
    }
    static void Main(string[] args)
    {
        AfficherBienvenue();
    }
}