using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCase
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    /// <summary>
    /// 微信用户在微信服务号对应的open id
    /// </summary>
    public string OpenId { get; set; }

    /// <summary>
    /// 微信用户在微信服务号对应的union id
    /// </summary>
    public string UnionId { get; set; }

    /// <summary>
    /// 关注:1|取消关注:0
    /// </summary>
    public byte? FollowStatus { get; set; }

    /// <summary>
    /// 微信用户在企业微信对应的external user id,  1代表联通；0代表断开；null代表从未联通过
    /// </summary>
    public string ExternalUserId { get; set; }

    public int? HospId { get; set; }

    public int? DeptId { get; set; }

    public int? DiagnosisId { get; set; }

    public int? OperationId { get; set; }

    public DateTime? OperationDate { get; set; }

    public DateTime? OperationDate2 { get; set; }

    public decimal? Degree { get; set; }

    public string InterviewName { get; set; }

    public string InterviewPhoneNumber { get; set; }

    public DateTime? BindTime { get; set; }

    public DateTime? Birthday { get; set; }

    public string RealName { get; set; }

    public string Name { get; set; }

    public string NameMd5 { get; set; }

    public string HospMd5 { get; set; }

    public string NameIdMd5 { get; set; }

    public int? VirtualNameId { get; set; }

    public string CardId { get; set; }

    public string Doctor { get; set; }

    public string Nurse { get; set; }

    public string Race { get; set; }

    public string NativePlace { get; set; }

    public string Occupation { get; set; }

    public string Marriage { get; set; }

    public short? Age { get; set; }

    public string AgeUnit { get; set; }

    public decimal? Height { get; set; }

    public string HeightUnit { get; set; }

    public decimal? Weight { get; set; }

    public string WeightUnit { get; set; }

    public byte? Sex { get; set; }

    public string PatientId { get; set; }

    public string BedNo { get; set; }

    public string InpNo { get; set; }

    public string Phone { get; set; }

    public string Symptom { get; set; }

    public string CurrentRecord { get; set; }

    public string PastRecord { get; set; }

    public string PersonalRecord { get; set; }

    public string FamilyRecord { get; set; }

    public byte? Status { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    /// <summary>
    /// 开始治疗时间
    /// </summary>
    public DateTime? StarttreatTime { get; set; }

    public byte? Active { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? LastUpdateTime { get; set; }

    public int? UnreadMessage { get; set; }

    public string OutpNo { get; set; }
}
