
namespace MeteoriteLandings.Data;

public class MeteoriteData : IMeteorites
{
    // This class mimics a database, handling file interaction. If this were a production application, the interface would 
    // be more fleshed out. The database would be stored on a server instead of a list in memory.
    // This will be a singleton class, with a single list to read from. I imagine this would have more stuff like more CRUD operations.
    private static List<Meteorite> Meteorites { get; set; }
    public MeteoriteData()
    {
        Meteorites = new List<Meteorite>();
        using (StreamReader stream = new StreamReader(new FileStream(@"C:\Users\chase\source\repos\MeteoriteLandings\MeteoriteLandings.Data\Meteorite_Landings.csv", FileMode.Open)))
        {
            // skip name line
            stream.ReadLine();
            while (!stream.EndOfStream)
            {
                string[] line = stream.ReadLine().Trim().Split(",");
                Meteorites.Add(new Meteorite(line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8], line[9]));
            }
        }
    }

    public IEnumerable<Meteorite> GetMeteorites()
    {
        return Meteorites;
    }
}
