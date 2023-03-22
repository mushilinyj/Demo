using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class GroupUserPermission
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Permission { get; set; }
}
