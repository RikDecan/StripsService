using StripDL;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new StripContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Console.WriteLine("Database is opnieuw aangemaakt");

        }
    }
}