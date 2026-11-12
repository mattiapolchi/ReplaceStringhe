string s, sFinale = "";
char c1, c2;

Console.WriteLine("inserisci la striga iniziale"); // chiede la stringa iniziale a cui sostutuire il carattere
s = Console.ReadLine(); 

Console.WriteLine("inserisci il carattere da sostituire"); // chiede il carattere da sostituire
c1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("inserisci il nuovo carattere"); // chiede il carattere da immettere
c2 = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < s.Length; i++) // scorre tutte i caratteri della stringhe principale
{
    if (s[i] == c1) // controlla se il carattere attuale nella posizione 'i' corrisponde a quello da sostituire
    {
        sFinale = sFinale + c2; // se corrisponde aggiunge il nuovo carattere alla stringa finale
    }
    else
    {
        sFinale = sFinale + s[i]; // altrimenti mantiene il carattere originale e lo aggiunge alla stringa finale
    }
}  
Console.WriteLine("la stringa finale modificata è: " + sFinale); // stampa la stringa finale aggiornata