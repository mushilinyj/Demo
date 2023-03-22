using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Group
{
    public int Id { get; set; }

    public int OwnerId { get; set; }

    /// <summary>
    /// 客户服务企业微信的user id 
    /// </summary>
    public string ServiceUserId { get; set; }

    public string Name { get; set; }

    public string Logo { get; set; }

    public string Remark { get; set; }

    public int? MemberNum { get; set; }

    public int? MedCaseNum { get; set; }

    public int? ProjectNum { get; set; }

    public byte? AutoBind { get; set; }

    public string RobotId { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? LastUpdateTime { get; set; }
}
