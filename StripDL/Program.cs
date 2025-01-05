using StripDL;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new StripContext())
        {

            try
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Console.WriteLine("Database is opnieuw aangemaakt");
            }
            catch (Exception)
            {
                throw new Exception("Database opnieuw aangemaken niet gelukt");
            }

            DatabaseSeeder.SeedFromFile(@"C:\Users\Rik\Documents\GitHub\StripsService\StripDL\stripsData.txt");
            Console.WriteLine("Database is gepopuleerd");


            //try
            //{
            //    DatabaseSeeder.SeedFromFile(@"C:\Users\Rik\Documents\GitHub\StripsService\StripDL\stripsData.txt");
            //    Console.WriteLine("Database is gepopuleerd");
            //}
            //catch (Exception)
            //{
            //    throw new Exception("Database populeren niet gelukt");
            //}

        }
    }
}