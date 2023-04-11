using System;
using System.Collections.Generic;

namespace ParserLibrary.SqlServer;

public partial class Datum
{
    public int Station { get; set; }

    public DateTime Date { get; set; }

    public decimal? WindDirection { get; set; }

    public int WindSpeed { get; set; }

    public decimal Temperature { get; set; }

    public int Humidity { get; set; }

    public decimal Pressure { get; set; }

    public int? SnowHeight { get; set; }

    public virtual Station StationNavigation { get; set; }
}
