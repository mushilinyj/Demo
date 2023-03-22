using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class DoctorFollowRecord
{
    public int Id { get; set; }

    public string OpenId { get; set; }

    public string UnionId { get; set; }

    /// <summary>
    /// 关注:1|取消关注:0
    /// </summary>
    public byte Status { get; set; }

    public DateTime AddTime { get; set; }
}
