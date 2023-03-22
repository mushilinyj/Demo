using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectTab
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string TabName { get; set; }

    public string Html { get; set; }

    public string Doc { get; set; }

    public string DocV1 { get; set; }

    public int Sort { get; set; }

    public byte Active { get; set; }
}
