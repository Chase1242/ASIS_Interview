using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoriteLandings.Data;

/// <summary>
/// The object representation of the data in the Meteorite_Landings.csv
/// </summary>
public class Meteorite
{   
    public Meteorite(string name, string id, string nameType, string recclass, string mass, string fall, string year, string reclat, string reclong, string geoLocation)
    {
        this.Name = name;
        int.TryParse(id, out int newId);
        this.Id = newId;
        this.NameType = (nameType.ToLower() == "valid") ? MeteoriteType.Valid : MeteoriteType.Invalid;
        this.Recclass = recclass;
        this.Mass = mass;
        this.Fall = (fall.ToLower() == "fell") ? Fall.Fell : Fall.Found;
        this.Year = year;
        double.TryParse(reclat, out double lat);
        double.TryParse(reclong, out double lon);
        this.Reclat = lat;
        this.Reclong = lon;
        this.GeoLocation = geoLocation;
    }


    //nametype,recclass,mass (g),fall,year,reclat,reclong,GeoLocation
    public string Name { get; set; }
    public int Id { get; set; }
    public MeteoriteType NameType { get; set; }
    public string Recclass { get; set; }
    public string Mass { get; set; }
    public Fall Fall { get; set; }
    public string Year { get; set; }
    public double Reclat { get; set; }
    public double Reclong { get; set; }
    public string GeoLocation { get; set; }
}

public enum MeteoriteType
{
    Valid,
    Invalid
}

public enum Fall
{
    Fell,
    Found
}
