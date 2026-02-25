using celloveszetCLI;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Cellovo> cellovok = new List<Cellovo>();
        string[] sorok = File.ReadAllLines("lovesek.csv");
        foreach (var sor in sorok)
        {
            cellovok.Add(new Cellovo(sor));
        }
        foreach (var c in cellovok)
        {
            Console.WriteLine($"{c.Nev} {c.legnagyobb()}");
        }
        //10. Legjobb lövő
        Cellovo legjobb = cellovok.MaxBy(c => c.legnagyobb());
        Console.WriteLine("Legnagyobb találatot lövő eredménye:");
        Console.WriteLine($"{legjobb.Nev} {legjobb.elsoloves} {legjobb.masodikloves} {legjobb.harmadikloves} {legjobb.negyedikloves}");

        //11. Leggyengébb lövő
        Cellovo min = cellovok.MinBy(c =>
        (c.elsoloves + c.masodikloves + c.harmadikloves + c.negyedikloves) / 4.0
        );
        Console.WriteLine("Leggyengébb lövő eredménye:");
        Console.WriteLine($"{min.Nev} {(min.elsoloves + min.masodikloves + min.harmadikloves + min.negyedikloves) / 4.0}");


    }
}