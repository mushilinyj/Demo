using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class User
{
    public int Id { get; set; }

    public string OpenId { get; set; }

    /// <summary>
    /// 关注:1|取消关注:0
    /// </summary>
    public byte? FollowStatus { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Hospital { get; set; }

    public int? HospId { get; set; }

    public string Section { get; set; }

    public string Phone { get; set; }

    public int? RoleId { get; set; }

    public int? ActiveGroupId { get; set; }

    public string Nickname { get; set; }

    public byte? Sex { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public string Province { get; set; }

    public string Language { get; set; }

    public string HeadImg { get; set; }

    public DateTime? SubscribeTime { get; set; }

    public string UnionId { get; set; }

    public string Remark { get; set; }

    public byte? SecrecyAgreement { get; set; }

    public string PcAccessToken { get; set; }

    public string ClientAccessToken { get; set; }

    public byte? Level { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? AddTime { get; set; }
}
