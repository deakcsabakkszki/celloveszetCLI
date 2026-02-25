namespace celloveszetCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("lovesek.csv");
            List<CelLovo> celLovok = new List<CelLovo>();

            foreach (var item in adatok)
            {
                celLovok.Add(new CelLovo(item));
            }


        }
    }
}
