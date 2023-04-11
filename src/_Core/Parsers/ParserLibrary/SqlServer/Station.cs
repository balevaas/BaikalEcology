using System;
using System.Collections.Generic;

namespace ParserLibrary.SqlServer;

public partial class Station
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public decimal Height { get; set; }

    public virtual ICollection<Datum> Data { get; } = new List<Datum>();
}
