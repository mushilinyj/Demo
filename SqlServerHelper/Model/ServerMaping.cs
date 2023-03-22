using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ServerMaping
{
    public int Id { get; set; }

    public string ServerIp { get; set; }

    public string ServerDns { get; set; }

    public string ServerName { get; set; }

    public string BackHostDns { get; set; }
}
