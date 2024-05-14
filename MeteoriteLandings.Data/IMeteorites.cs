using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoriteLandings.Data;

/// <summary>
/// The interface to handle
/// </summary>
public interface IMeteorites
{
    public IEnumerable<Meteorite> GetMeteorites();
}
