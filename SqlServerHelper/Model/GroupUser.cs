using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class GroupUser
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int UserId { get; set; }

    public int? GroupRoleId { get; set; }

    public int? Permission { get; set; }

    public string InpNo { get; set; }

    public DateTime? AddTime { get; set; }
}
