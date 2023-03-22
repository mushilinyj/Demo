using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class SolarLunarCalendar
{
    public int Id { get; set; }

    /// <summary>
    /// 阳历
    /// </summary>
    public DateTime Solar { get; set; }

    /// <summary>
    /// 阴历
    /// </summary>
    public string Lunar { get; set; }

    /// <summary>
    /// 节日名
    /// </summary>
    public string Festival { get; set; }

    public string WeekdayFestival { get; set; }

    public string TraditionalFestival { get; set; }

    public string SolarTerms { get; set; }
}
