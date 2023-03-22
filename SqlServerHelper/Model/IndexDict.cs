using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class IndexDict
{
    public int Id { get; set; }

    public string Key { get; set; }

    public string Name { get; set; }

    public string Alias { get; set; }

    public string EnumKeyValue { get; set; }

    public int? GroupId { get; set; }

    public byte? Type { get; set; }

    public byte? Status { get; set; }

    public int MedCaseCateId { get; set; }

    public string Remark { get; set; }

    public byte? Active { get; set; }

    public int? AddUserId { get; set; }

    public DateTime? AddTime { get; set; }

    public int? LastUpdateUserId { get; set; }

    public DateTime? LastUpdateTime { get; set; }

    public string ShowHiddenRule { get; set; }
}
