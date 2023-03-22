using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class UserLoginserverRecord
{
    public int Id { get; set; }

    public string OpenId { get; set; }

    public string Nickname { get; set; }

    public string AddTime { get; set; }

    public int ServerMapingId { get; set; }
}
