using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SqlServerHelper.Model;

public partial class MedioContext : DbContext
{
    public MedioContext()
    {
    }

    public MedioContext(DbContextOptions<MedioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChatRecord> ChatRecords { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ContentExamine> ContentExamines { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Diagnosis> Diagnoses { get; set; }

    public virtual DbSet<DoctorFollowRecord> DoctorFollowRecords { get; set; }

    public virtual DbSet<FileUploadLogger> FileUploadLoggers { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupMedCaseCoreDatum> GroupMedCaseCoreData { get; set; }

    public virtual DbSet<GroupPatientBindApply> GroupPatientBindApplies { get; set; }

    public virtual DbSet<GroupPatientBindInfoBak> GroupPatientBindInfoBaks { get; set; }

    public virtual DbSet<GroupRole> GroupRoles { get; set; }

    public virtual DbSet<GroupUser> GroupUsers { get; set; }

    public virtual DbSet<GroupUserApply> GroupUserApplies { get; set; }

    public virtual DbSet<GroupUserPermission> GroupUserPermissions { get; set; }

    public virtual DbSet<HashTable> HashTables { get; set; }

    public virtual DbSet<HashTableOnlineMainV1> HashTableOnlineMainV1s { get; set; }

    public virtual DbSet<Hosp> Hosps { get; set; }

    public virtual DbSet<Index> Indices { get; set; }

    public virtual DbSet<IndexCollector> IndexCollectors { get; set; }

    public virtual DbSet<IndexCollectorIndexDict> IndexCollectorIndexDicts { get; set; }

    public virtual DbSet<IndexDict> IndexDicts { get; set; }

    public virtual DbSet<IndexKnowledgeBase> IndexKnowledgeBases { get; set; }

    public virtual DbSet<Interview> Interviews { get; set; }

    public virtual DbSet<InterviewCalendar> InterviewCalendars { get; set; }

    public virtual DbSet<InterviewOneTimePushRecord> InterviewOneTimePushRecords { get; set; }

    public virtual DbSet<InterviewPushFailedRecord> InterviewPushFailedRecords { get; set; }

    public virtual DbSet<InterviewPushQueue> InterviewPushQueues { get; set; }

    public virtual DbSet<InterviewPushRecord> InterviewPushRecords { get; set; }

    public virtual DbSet<InterviewPushRecordView> InterviewPushRecordViews { get; set; }

    public virtual DbSet<InterviewWaitingToSend> InterviewWaitingToSends { get; set; }

    public virtual DbSet<MedCase> MedCases { get; set; }

    public virtual DbSet<MedCaseAnswerRecord> MedCaseAnswerRecords { get; set; }

    public virtual DbSet<MedCaseCate> MedCaseCates { get; set; }

    public virtual DbSet<MedCaseCoreDatum> MedCaseCoreData { get; set; }

    public virtual DbSet<MedCaseExt1> MedCaseExt1s { get; set; }

    public virtual DbSet<MedCaseGroup> MedCaseGroups { get; set; }

    public virtual DbSet<MedCaseGroupLiveness> MedCaseGroupLivenesses { get; set; }

    public virtual DbSet<MedCaseGroupRecord> MedCaseGroupRecords { get; set; }

    public virtual DbSet<MedCaseInterview> MedCaseInterviews { get; set; }

    public virtual DbSet<MedCaseInterviewRecord> MedCaseInterviewRecords { get; set; }

    public virtual DbSet<MedCaseInterviewRepledView> MedCaseInterviewRepledViews { get; set; }

    public virtual DbSet<MedCaseMedium> MedCaseMedia { get; set; }

    public virtual DbSet<MedCaseMessage> MedCaseMessages { get; set; }

    public virtual DbSet<MedCaseMessageAuth> MedCaseMessageAuths { get; set; }

    public virtual DbSet<MedCaseNode> MedCaseNodes { get; set; }

    public virtual DbSet<MedCaseNodeProperty> MedCaseNodeProperties { get; set; }

    public virtual DbSet<MedCasePerformLog> MedCasePerformLogs { get; set; }

    public virtual DbSet<MedCaseRecord> MedCaseRecords { get; set; }

    public virtual DbSet<MedCaseSmsStatusQueue> MedCaseSmsStatusQueues { get; set; }

    public virtual DbSet<MedCaseUpload1> MedCaseUpload1s { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageTitle> MessageTitles { get; set; }

    public virtual DbSet<OpenVsUnion> OpenVsUnions { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<PatientFollowRecord> PatientFollowRecords { get; set; }

    public virtual DbSet<PatientFollowUpRemind> PatientFollowUpReminds { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectHistoryCase> ProjectHistoryCases { get; set; }

    public virtual DbSet<ProjectIndexDict> ProjectIndexDicts { get; set; }

    public virtual DbSet<ProjectLockMedCase> ProjectLockMedCases { get; set; }

    public virtual DbSet<ProjectMedCase> ProjectMedCases { get; set; }

    public virtual DbSet<ProjectMedCaseDelRecord> ProjectMedCaseDelRecords { get; set; }

    public virtual DbSet<ProjectOutinQuery> ProjectOutinQueries { get; set; }

    public virtual DbSet<ProjectPerformLog> ProjectPerformLogs { get; set; }

    public virtual DbSet<ProjectTab> ProjectTabs { get; set; }

    public virtual DbSet<ProjectTabConfig> ProjectTabConfigs { get; set; }

    public virtual DbSet<ProjectTabQuery> ProjectTabQueries { get; set; }

    public virtual DbSet<ServerMaping> ServerMapings { get; set; }

    public virtual DbSet<ServicePeriod> ServicePeriods { get; set; }

    public virtual DbSet<SmsPushTaskQueue> SmsPushTaskQueues { get; set; }

    public virtual DbSet<SolarLunarCalendar> SolarLunarCalendars { get; set; }

    public virtual DbSet<Statistic> Statistics { get; set; }

    public virtual DbSet<StatisticsType> StatisticsTypes { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLoginserverRecord> UserLoginserverRecords { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<VirtualFirstName> VirtualFirstNames { get; set; }

    public virtual DbSet<VirtualLastName> VirtualLastNames { get; set; }

    public virtual DbSet<VirtualName> VirtualNames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conn = SettingsHelper.GetSectionValue("WorkMedioLabs");
        optionsBuilder.UseSqlServer(conn);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.UseCollation("Chinese_PRC_CI_AS");

        modelBuilder.Entity<ChatRecord>(entity =>
        {
            entity.ToTable("CHAT_RECORD");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("CITY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(100)
                .HasColumnName("AREA_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<ContentExamine>(entity =>
        {
            entity.ToTable("CONTENT_EXAMINE");

            entity.HasIndex(e => e.GroupId, "IX_CONTENT_EXAMINE_GROUP_ID");

            entity.HasIndex(e => e.InterviewId, "IX_CONTENT_EXAMINE_INTERVIEW_ID");

            entity.HasIndex(e => e.ProjectId, "IX_CONTENT_EXAMINE_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content)
                .IsRequired()
                .HasColumnName("CONTENT");
            entity.Property(e => e.ErrorMsg).HasColumnName("ERROR_MSG");
            entity.Property(e => e.ExamineTime)
                .HasColumnType("datetime")
                .HasColumnName("EXAMINE_TIME");
            entity.Property(e => e.ExamineUserId).HasColumnName("EXAMINE_USER_ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Status)
                .HasComment("审查状态:0待审1通过2不过")
                .HasColumnName("STATUS");
            entity.Property(e => e.SubmitTime)
                .HasColumnType("datetime")
                .HasColumnName("SUBMIT_TIME");
            entity.Property(e => e.SubmitUserId).HasColumnName("SUBMIT_USER_ID");
        });

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.ToTable("DEPT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.ToTable("DIAGNOSIS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Icd10Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ICD10_CODE");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(800)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<DoctorFollowRecord>(entity =>
        {
            entity.ToTable("DOCTOR_FOLLOW_RECORD", tb => tb.HasTrigger("TRIGGER_DOCTOR_FOLLOW_RECORD"));

            entity.HasIndex(e => e.OpenId, "IX_DOCTOR_FOLLOW_RECORD_OPEN_ID");

            entity.HasIndex(e => e.UnionId, "IX_DOCTOR_FOLLOW_RECORD_UNION_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.OpenId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.Status)
                .HasComment("关注:1|取消关注:0")
                .HasColumnName("STATUS");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
        });

        modelBuilder.Entity<FileUploadLogger>(entity =>
        {
            entity.ToTable("FILE_UPLOAD_LOGGER");

            entity.HasIndex(e => e.FileName, "IX_FILE_UPLOAD_LOGGER_FILE_NAME");

            entity.HasIndex(e => e.GroupId, "IX_FILE_UPLOAD_LOGGER_GROUP_ID");

            entity.HasIndex(e => e.UserId, "IX_FILE_UPLOAD_LOGGER_USER_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATA_HASH");
            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(260)
                .HasColumnName("FILE_NAME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.UploadTime)
                .HasColumnType("datetime")
                .HasColumnName("UPLOAD_TIME");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("GROUP");

            entity.HasIndex(e => e.OwnerId, "IX_GROUP_OWNER_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.AutoBind)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AUTO_BIND");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_TIME");
            entity.Property(e => e.Logo)
                .HasMaxLength(4098)
                .IsUnicode(false)
                .HasColumnName("LOGO");
            entity.Property(e => e.MedCaseNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MED_CASE_NUM");
            entity.Property(e => e.MemberNum)
                .HasDefaultValueSql("((1))")
                .HasColumnName("MEMBER_NUM");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.OwnerId).HasColumnName("OWNER_ID");
            entity.Property(e => e.ProjectNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PROJECT_NUM");
            entity.Property(e => e.Remark)
                .HasMaxLength(1024)
                .HasColumnName("REMARK");
            entity.Property(e => e.RobotId)
                .HasMaxLength(50)
                .HasColumnName("ROBOT_ID");
            entity.Property(e => e.ServiceUserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("客户服务企业微信的user id ")
                .HasColumnName("SERVICE_USER_ID");
        });

        modelBuilder.Entity<GroupMedCaseCoreDatum>(entity =>
        {
            entity.ToTable("GROUP_MED_CASE_CORE_DATA");

            entity.HasIndex(e => e.DataHash, "IX_GROUP_MED_CASE_CORE_DATA_DATA_HASH");

            entity.HasIndex(e => e.GroupId, "IX_GROUP_MED_CASE_CORE_DATA_GROUP_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.DataHash)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATA_HASH");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.ImageBits)
                .HasColumnType("image")
                .HasColumnName("IMAGE_BITS");
            entity.Property(e => e.ImageDate)
                .HasColumnType("datetime")
                .HasColumnName("IMAGE_DATE");
            entity.Property(e => e.ImageTitle)
                .HasMaxLength(256)
                .HasColumnName("IMAGE_TITLE");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.Refreshed)
                .HasDefaultValueSql("((1))")
                .HasColumnName("REFRESHED");
        });

        modelBuilder.Entity<GroupPatientBindApply>(entity =>
        {
            entity.ToTable("GROUP_PATIENT_BIND_APPLY");

            entity.HasIndex(e => e.GroupId, "IX_GROUP_PATIENT_BIND_APPLY_GROUP_ID");

            entity.HasIndex(e => e.OpenId, "IX_GROUP_PATIENT_BIND_APPLY_OPEN_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.ApprovalTime)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_TIME");
            entity.Property(e => e.CardId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CARD_ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INP_NO");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.OpenId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.Reason)
                .HasMaxLength(100)
                .HasColumnName("REASON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
        });

        modelBuilder.Entity<GroupPatientBindInfoBak>(entity =>
        {
            entity.ToTable("GROUP_PATIENT_BIND_INFO_BAK");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INP_NO");
            entity.Property(e => e.InterviewName)
                .HasMaxLength(30)
                .HasColumnName("INTERVIEW_NAME");
            entity.Property(e => e.InterviewPhoneNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INTERVIEW_PHONE_NUMBER");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.OpenId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
        });

        modelBuilder.Entity<GroupRole>(entity =>
        {
            entity.ToTable("GROUP_ROLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<GroupUser>(entity =>
        {
            entity.ToTable("GROUP_USER");

            entity.HasIndex(e => e.GroupId, "IX_GROUP_USER_GROUP_ID");

            entity.HasIndex(e => e.GroupRoleId, "IX_GROUP_USER_GROUP_ROLE_ID");

            entity.HasIndex(e => e.UserId, "IX_GROUP_USER_USER_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.GroupRoleId).HasColumnName("GROUP_ROLE_ID");
            entity.Property(e => e.InpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INP_NO");
            entity.Property(e => e.Permission)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PERMISSION");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<GroupUserApply>(entity =>
        {
            entity.ToTable("GROUP_USER_APPLY");

            entity.HasIndex(e => e.GroupId, "IX_GROUP_USER_APPLY_GROUP_ID");

            entity.HasIndex(e => e.UserId, "IX_GROUP_USER_APPLY_USER_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.ApprovalTime)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Reason)
                .HasMaxLength(100)
                .HasColumnName("REASON");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasColumnName("STATUS");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<GroupUserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_USER_PERMISSION");

            entity.ToTable("GROUP_USER_PERMISSION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("NAME");
            entity.Property(e => e.Permission).HasColumnName("PERMISSION");
        });

        modelBuilder.Entity<HashTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HASHTABLE");

            entity.ToTable("HashTable");

            entity.HasIndex(e => e.HashCode, "IX_HashTable");

            entity.Property(e => e.CheckInTime).HasColumnType("datetime");
            entity.Property(e => e.Vcode).HasColumnName("VCode");
        });

        modelBuilder.Entity<HashTableOnlineMainV1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HashTableOnline");

            entity.ToTable("HashTableOnlineMainV1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.M10001).HasColumnType("datetime");
            entity.Property(e => e.M10002).HasColumnType("datetime");
            entity.Property(e => e.M10003).HasColumnType("datetime");
            entity.Property(e => e.M10004).HasColumnType("datetime");
            entity.Property(e => e.M10005).HasColumnType("datetime");
            entity.Property(e => e.M10006).HasColumnType("datetime");
            entity.Property(e => e.M10007).HasColumnType("datetime");
            entity.Property(e => e.M10008).HasColumnType("datetime");
            entity.Property(e => e.M10009).HasColumnType("datetime");
            entity.Property(e => e.M10010).HasColumnType("datetime");
            entity.Property(e => e.M10011).HasColumnType("datetime");
            entity.Property(e => e.Vcode).HasColumnName("VCode");
        });

        modelBuilder.Entity<Hosp>(entity =>
        {
            entity.ToTable("HOSP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alias)
                .HasMaxLength(400)
                .HasColumnName("ALIAS");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Index>(entity =>
        {
            entity.ToTable("INDEX");

            entity.HasIndex(e => e.CateId, "IX_INDEX_CATE_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CateId).HasColumnName("CATE_ID");
            entity.Property(e => e.EnumValues).HasColumnName("ENUM_VALUES");
            entity.Property(e => e.IndexType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("INDEX_TYPE");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<IndexCollector>(entity =>
        {
            entity.ToTable("INDEX_COLLECTOR");

            entity.HasIndex(e => e.GroupId, "IX_INDEX_COLLECTOR_GROUP_ID");

            entity.HasIndex(e => e.Sort, "IX_INDEX_COLLECTOR_SORT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SORT");
        });

        modelBuilder.Entity<IndexCollectorIndexDict>(entity =>
        {
            entity.ToTable("INDEX_COLLECTOR_INDEX_DICT");

            entity.HasIndex(e => e.IndexCollectorId, "IX_INDEX_COLLECTOR_INDEX_DICT_INDEX_COLLECTOR_ID");

            entity.HasIndex(e => e.IndexDictId, "IX_INDEX_COLLECTOR_INDEX_DICT_INDEX_DICT_ID");

            entity.HasIndex(e => e.Sort, "IX_INDEX_COLLECTOR_INDEX_DICT_SORT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IndexCollectorId).HasColumnName("INDEX_COLLECTOR_ID");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SORT");
        });

        modelBuilder.Entity<IndexDict>(entity =>
        {
            entity.ToTable("INDEX_DICT");

            entity.HasIndex(e => e.Active, "IX_INDEX_DICT_ACTIVE");

            entity.HasIndex(e => e.AddUserId, "IX_INDEX_DICT_ADD_USER_ID");

            entity.HasIndex(e => e.GroupId, "IX_INDEX_DICT_GROUP_ID");

            entity.HasIndex(e => e.Key, "IX_INDEX_DICT_KEY").IsUnique();

            entity.HasIndex(e => e.LastUpdateUserId, "IX_INDEX_DICT_LAST_UPDATE_USER_ID");

            entity.HasIndex(e => e.MedCaseCateId, "IX_INDEX_DICT_MED_CASE_CATE_ID");

            entity.HasIndex(e => e.Name, "IX_INDEX_DICT_NAME").IsUnique();

            entity.HasIndex(e => e.Status, "IX_INDEX_DICT_STATUS");

            entity.HasIndex(e => e.Type, "IX_INDEX_DICT_TYPE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.AddUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ADD_USER_ID");
            entity.Property(e => e.Alias)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("ALIAS");
            entity.Property(e => e.EnumKeyValue).HasColumnName("ENUM_KEY_VALUE");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Key)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("KEY");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_TIME");
            entity.Property(e => e.LastUpdateUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LAST_UPDATE_USER_ID");
            entity.Property(e => e.MedCaseCateId).HasColumnName("MED_CASE_CATE_ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(160)
                .HasColumnName("NAME");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("REMARK");
            entity.Property(e => e.ShowHiddenRule)
                .HasMaxLength(100)
                .HasColumnName("SHOW_HIDDEN_RULE");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("((9))")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<IndexKnowledgeBase>(entity =>
        {
            entity.ToTable("INDEX_KNOWLEDGE_BASE");

            entity.HasIndex(e => new { e.Regex, e.Unit }, "IX_INDEX_KNOWLEDGE_BASE_REGEX_UNIT").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Max)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAX");
            entity.Property(e => e.Min)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MIN");
            entity.Property(e => e.Regex)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("REGEX");
            entity.Property(e => e.StatType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STAT_TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("UNIT");
        });

        modelBuilder.Entity<Interview>(entity =>
        {
            entity.ToTable("INTERVIEW");

            entity.HasIndex(e => e.ProjectId, "IX_INTERVIEW_PROJECT_ID");

            entity.HasIndex(e => e.RemindingWho, "IX_INTERVIEW_REMINDING_WHO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.FestivalDate)
                .HasMaxLength(50)
                .HasColumnName("FESTIVAL_DATE");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.Model)
                .HasDefaultValueSql("((2))")
                .HasComment("1即时随访2定时随访3节日关怀4纪念日问候")
                .HasColumnName("MODEL");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.PushQuestion)
                .HasDefaultValueSql("((1))")
                .HasColumnName("PUSH_QUESTION");
            entity.Property(e => e.RemindMode).HasColumnName("REMIND_MODE");
            entity.Property(e => e.RemindOnSameDay)
                .HasDefaultValueSql("((1))")
                .HasComment("推送的时间与计划的时间是否必须同一天，1为是，0表示推送的时间可以晚于计划时间，仍然补推")
                .HasColumnName("REMIND_ON_SAME_DAY");
            entity.Property(e => e.RemindingContent).HasColumnName("REMINDING_CONTENT");
            entity.Property(e => e.RemindingWho)
                .HasComment("0是患者1是医生")
                .HasColumnName("REMINDING_WHO");
            entity.Property(e => e.ResendTimes).HasColumnName("RESEND_TIMES");
            entity.Property(e => e.Sms)
                .HasComment("0关闭1开启短信提醒功能")
                .HasColumnName("SMS");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SORT");
            entity.Property(e => e.Step).HasColumnName("STEP");
            entity.Property(e => e.SubmitType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SUBMIT_TYPE");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("('08:00:00')")
                .HasColumnName("TIME");
            entity.Property(e => e.Wechat)
                .HasDefaultValueSql("((1))")
                .HasColumnName("WECHAT");
        });

        modelBuilder.Entity<InterviewCalendar>(entity =>
        {
            entity.ToTable("INTERVIEW_CALENDAR");

            entity.HasIndex(e => e.GroupId, "IX_INTERVIEW_CALENDAR_GROUP_ID");

            entity.HasIndex(e => e.InterviewDate, "IX_INTERVIEW_CALENDAR_INTERVIEW_DATE");

            entity.HasIndex(e => e.InterviewId, "IX_INTERVIEW_CALENDAR_INTERVIEW_ID");

            entity.HasIndex(e => e.InterviewWho, "IX_INTERVIEW_CALENDAR_INTERVIEW_WHO");

            entity.HasIndex(e => e.ProjectId, "IX_INTERVIEW_CALENDAR_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InterviewDate)
                .HasColumnType("date")
                .HasColumnName("INTERVIEW_DATE");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.InterviewWho)
                .HasComment("0是患者1是医生")
                .HasColumnName("INTERVIEW_WHO");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Sent).HasColumnName("SENT");
            entity.Property(e => e.SentAndReply).HasColumnName("SENT_AND_REPLY");
            entity.Property(e => e.SentNoReply).HasColumnName("SENT_NO_REPLY");
            entity.Property(e => e.WaitingToSend).HasColumnName("WAITING_TO_SEND");
        });

        modelBuilder.Entity<InterviewOneTimePushRecord>(entity =>
        {
            entity.ToTable("INTERVIEW_ONE_TIME_PUSH_RECORD");

            entity.HasIndex(e => e.GroupId, "IX_INTERVIEW_ONE_TIME_PUSH_RECORD_GROUP_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.OpenIds)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("OPEN_IDS");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("REMARK");
            entity.Property(e => e.Result).HasColumnName("RESULT");
            entity.Property(e => e.SendTime)
                .HasColumnType("datetime")
                .HasColumnName("SEND_TIME");
            entity.Property(e => e.SendUserId).HasColumnName("SEND_USER_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<InterviewPushFailedRecord>(entity =>
        {
            entity.ToTable("INTERVIEW_PUSH_FAILED_RECORD");

            entity.HasIndex(e => e.InterviewId, "IX_INTERVIEW_PUSH_FAILED_RECORD_INTERVIEW_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_INTERVIEW_PUSH_FAILED_RECORD_MED_CASE_ID");

            entity.HasIndex(e => e.RemindingWho, "IX_INTERVIEW_PUSH_FAILED_RECORD_REMINDING_WHO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.ErrorMsg).HasColumnName("ERROR_MSG");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.OpenId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.PushMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('WeChat')")
                .HasColumnName("PUSH_MODE");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.RemindingWho)
                .HasDefaultValueSql("((0))")
                .HasColumnName("REMINDING_WHO");
            entity.Property(e => e.SendUserId).HasColumnName("SEND_USER_ID");
        });

        modelBuilder.Entity<InterviewPushQueue>(entity =>
        {
            entity.ToTable("INTERVIEW_PUSH_QUEUE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.RemindingWho).HasColumnName("REMINDING_WHO");
        });

        modelBuilder.Entity<InterviewPushRecord>(entity =>
        {
            entity.ToTable("INTERVIEW_PUSH_RECORD");

            entity.HasIndex(e => e.InterviewId, "IX_INTERVIEW_PUSH_RECORD_INTERVIEW_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_INTERVIEW_PUSH_RECORD_MED_CASE_ID");

            entity.HasIndex(e => e.OpenId, "IX_INTERVIEW_PUSH_RECORD_OPEN_D");

            entity.HasIndex(e => e.RemindingWho, "IX_INTERVIEW_PUSH_RECORD_REMINDING_WHO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.OpenId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.PushMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('WeChat')")
                .HasColumnName("PUSH_MODE");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.RemindingWho)
                .HasDefaultValueSql("((0))")
                .HasColumnName("REMINDING_WHO");
            entity.Property(e => e.SendUserId).HasColumnName("SEND_USER_ID");
        });

        modelBuilder.Entity<InterviewPushRecordView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("INTERVIEW_PUSH_RECORD_VIEWS");

            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<InterviewWaitingToSend>(entity =>
        {
            entity.ToTable("INTERVIEW_WAITING_TO_SEND");

            entity.HasIndex(e => e.InterviewDate, "IX_INTERVIEW_WAITING_TO_SEND_INTERVIEW_DATE");

            entity.HasIndex(e => e.InterviewId, "IX_INTERVIEW_WAITING_TO_SEND_INTERVIEW_ID");

            entity.HasIndex(e => e.InterviewWho, "IX_INTERVIEW_WAITING_TO_SEND_INTERVIEW_WHO");

            entity.HasIndex(e => e.ProjectId, "IX_INTERVIEW_WAITING_TO_SEND_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InterviewDate)
                .HasColumnType("date")
                .HasColumnName("INTERVIEW_DATE");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.InterviewWho).HasColumnName("INTERVIEW_WHO");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        });

        modelBuilder.Entity<MedCase>(entity =>
        {
            entity.ToTable("MED_CASE", tb => tb.HasTrigger("TRIGGER_INSERT_MED_CASE"));

            entity.HasIndex(e => e.DeptId, "IX_MED_CASE_DEPT_ID");

            entity.HasIndex(e => e.DiagnosisId, "IX_MED_CASE_DIAGNOSIS_ID");

            entity.HasIndex(e => e.GroupId, "IX_MED_CASE_GROUP_ID");

            entity.HasIndex(e => e.HospId, "IX_MED_CASE_HOSP_ID");

            entity.HasIndex(e => e.HospMd5, "IX_MED_CASE_HOSP_MD5");

            entity.HasIndex(e => e.NameIdMd5, "IX_MED_CASE_NAME_ID_MD5");

            entity.HasIndex(e => e.NameMd5, "IX_MED_CASE_NAME_MD5");

            entity.HasIndex(e => e.OpenId, "IX_MED_CASE_OPEN_ID");

            entity.HasIndex(e => e.OperationId, "IX_MED_CASE_OPERATION_ID");

            entity.HasIndex(e => e.VirtualNameId, "IX_MED_CASE_VIRTUAL_NAME_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.AdmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("ADMISSION_DATE");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.AgeUnit)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'岁')")
                .HasColumnName("AGE_UNIT");
            entity.Property(e => e.BedNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BED_NO");
            entity.Property(e => e.BindTime)
                .HasColumnType("datetime")
                .HasColumnName("BIND_TIME");
            entity.Property(e => e.Birthday)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDAY");
            entity.Property(e => e.CardId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CARD_ID");
            entity.Property(e => e.CurrentRecord).HasColumnName("CURRENT_RECORD");
            entity.Property(e => e.Degree)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DEGREE");
            entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");
            entity.Property(e => e.DiagnosisId).HasColumnName("DIAGNOSIS_ID");
            entity.Property(e => e.DischargeDate)
                .HasColumnType("datetime")
                .HasColumnName("DISCHARGE_DATE");
            entity.Property(e => e.Doctor)
                .HasMaxLength(30)
                .HasColumnName("DOCTOR");
            entity.Property(e => e.ExternalUserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("微信用户在企业微信对应的external user id,  1代表联通；0代表断开；null代表从未联通过")
                .HasColumnName("EXTERNAL_USER_ID");
            entity.Property(e => e.FamilyRecord).HasColumnName("FAMILY_RECORD");
            entity.Property(e => e.FollowStatus)
                .HasDefaultValueSql("((0))")
                .HasComment("关注:1|取消关注:0")
                .HasColumnName("FOLLOW_STATUS");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HEIGHT");
            entity.Property(e => e.HeightUnit)
                .HasMaxLength(5)
                .HasColumnName("HEIGHT_UNIT");
            entity.Property(e => e.HospId).HasColumnName("HOSP_ID");
            entity.Property(e => e.HospMd5)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("HOSP_MD5");
            entity.Property(e => e.InpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INP_NO");
            entity.Property(e => e.InterviewName)
                .HasMaxLength(30)
                .HasColumnName("INTERVIEW_NAME");
            entity.Property(e => e.InterviewPhoneNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INTERVIEW_PHONE_NUMBER");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_TIME");
            entity.Property(e => e.Marriage)
                .HasMaxLength(20)
                .HasColumnName("MARRIAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.NameIdMd5)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("NAME_ID_MD5");
            entity.Property(e => e.NameMd5)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("NAME_MD5");
            entity.Property(e => e.NativePlace)
                .HasMaxLength(50)
                .HasColumnName("NATIVE_PLACE");
            entity.Property(e => e.Nurse)
                .HasMaxLength(30)
                .HasColumnName("NURSE");
            entity.Property(e => e.Occupation)
                .HasMaxLength(50)
                .HasColumnName("OCCUPATION");
            entity.Property(e => e.OpenId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("微信用户在微信服务号对应的open id")
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.OperationDate)
                .HasColumnType("datetime")
                .HasColumnName("OPERATION_DATE");
            entity.Property(e => e.OperationDate2)
                .HasColumnType("datetime")
                .HasColumnName("OPERATION_DATE_2");
            entity.Property(e => e.OperationId).HasColumnName("OPERATION_ID");
            entity.Property(e => e.OutpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OUTP_NO");
            entity.Property(e => e.PastRecord).HasColumnName("PAST_RECORD");
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PATIENT_ID");
            entity.Property(e => e.PersonalRecord).HasColumnName("PERSONAL_RECORD");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Race)
                .HasMaxLength(50)
                .HasColumnName("RACE");
            entity.Property(e => e.RealName)
                .HasMaxLength(30)
                .HasColumnName("REAL_NAME");
            entity.Property(e => e.Sex).HasColumnName("SEX");
            entity.Property(e => e.StarttreatTime)
                .HasComment("开始治疗时间")
                .HasColumnType("datetime")
                .HasColumnName("STARTTREAT_TIME");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasColumnName("STATUS");
            entity.Property(e => e.Symptom).HasColumnName("SYMPTOM");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("微信用户在微信服务号对应的union id")
                .HasColumnName("UNION_ID");
            entity.Property(e => e.UnreadMessage).HasColumnName("UNREAD_MESSAGE");
            entity.Property(e => e.VirtualNameId).HasColumnName("VIRTUAL_NAME_ID");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WEIGHT");
            entity.Property(e => e.WeightUnit)
                .HasMaxLength(5)
                .HasColumnName("WEIGHT_UNIT");
        });

        modelBuilder.Entity<MedCaseAnswerRecord>(entity =>
        {
            entity.ToTable("MED_CASE_ANSWER_RECORD");

            entity.HasIndex(e => e.MedCaseId, "IX_MED_CASE_ANSWER_RECORD_MED_CASE_ID");

            entity.HasIndex(e => e.RobotId, "IX_MED_CASE_ANSWER_RECORD_ROBOT_ID");

            entity.HasIndex(e => e.UnionId, "IX_MED_CASE_ANSWER_RECORD_UNION_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.RobotId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("ROBOT_ID");
            entity.Property(e => e.Unanswered).HasColumnName("UNANSWERED");
            entity.Property(e => e.UnionId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
        });

        modelBuilder.Entity<MedCaseCate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INDEX_CATE");

            entity.ToTable("MED_CASE_CATE");

            entity.HasIndex(e => e.Name, "IX_INDEX_CATE_NAME").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Key)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KEY");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<MedCaseCoreDatum>(entity =>
        {
            entity.HasKey(e => e.DataHash);

            entity.ToTable("MED_CASE_CORE_DATA");

            entity.Property(e => e.DataHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATA_HASH");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.CoreData)
                .IsRequired()
                .HasColumnName("CORE_DATA");
            entity.Property(e => e.ImageBits)
                .HasColumnType("image")
                .HasColumnName("IMAGE_BITS");
            entity.Property(e => e.ImageDate)
                .HasColumnType("datetime")
                .HasColumnName("IMAGE_DATE");
            entity.Property(e => e.ImageTitle)
                .HasMaxLength(256)
                .HasColumnName("IMAGE_TITLE");
        });

        modelBuilder.Entity<MedCaseExt1>(entity =>
        {
            entity.HasKey(e => e.MedCaseId);

            entity.ToTable("MED_CASE_EXT_1");

            entity.Property(e => e.MedCaseId)
                .ValueGeneratedNever()
                .HasColumnName("MED_CASE_ID");
            entity.Property(e => e.IndexId1).HasColumnName("INDEX_ID_1");
            entity.Property(e => e.IndexId10).HasColumnName("INDEX_ID_10");
            entity.Property(e => e.IndexId2).HasColumnName("INDEX_ID_2");
            entity.Property(e => e.IndexId3).HasColumnName("INDEX_ID_3");
            entity.Property(e => e.IndexId4).HasColumnName("INDEX_ID_4");
            entity.Property(e => e.IndexId5).HasColumnName("INDEX_ID_5");
            entity.Property(e => e.IndexId6).HasColumnName("INDEX_ID_6");
            entity.Property(e => e.IndexId7).HasColumnName("INDEX_ID_7");
            entity.Property(e => e.IndexId8).HasColumnName("INDEX_ID_8");
            entity.Property(e => e.IndexId9).HasColumnName("INDEX_ID_9");
            entity.Property(e => e.IndexValue1).HasColumnName("INDEX_VALUE_1");
            entity.Property(e => e.IndexValue10).HasColumnName("INDEX_VALUE_10");
            entity.Property(e => e.IndexValue2).HasColumnName("INDEX_VALUE_2");
            entity.Property(e => e.IndexValue3).HasColumnName("INDEX_VALUE_3");
            entity.Property(e => e.IndexValue4).HasColumnName("INDEX_VALUE_4");
            entity.Property(e => e.IndexValue5).HasColumnName("INDEX_VALUE_5");
            entity.Property(e => e.IndexValue6).HasColumnName("INDEX_VALUE_6");
            entity.Property(e => e.IndexValue7).HasColumnName("INDEX_VALUE_7");
            entity.Property(e => e.IndexValue8).HasColumnName("INDEX_VALUE_8");
            entity.Property(e => e.IndexValue9).HasColumnName("INDEX_VALUE_9");
        });

        modelBuilder.Entity<MedCaseGroup>(entity =>
        {
            entity.ToTable("MED_CASE_GROUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTimeValue)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_VALUE");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("NAME");
            entity.Property(e => e.NumericValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NUMERIC_VALUE");
            entity.Property(e => e.Source)
                .HasMaxLength(400)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<MedCaseGroupLiveness>(entity =>
        {
            entity.ToTable("MED_CASE_GROUP_LIVENESS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.OpenId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
        });

        modelBuilder.Entity<MedCaseGroupRecord>(entity =>
        {
            entity.ToTable("MED_CASE_GROUP_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");
            entity.Property(e => e.UpdateValue).HasColumnName("UPDATE_VALUE");
            entity.Property(e => e.UpdateWaya)
                .HasMaxLength(100)
                .HasColumnName("UPDATE_WAYA");
        });

        modelBuilder.Entity<MedCaseInterview>(entity =>
        {
            entity.ToTable("MED_CASE_INTERVIEW", tb =>
                {
                    tb.HasTrigger("SatisfactionSurveyGrossScore");
                    tb.HasTrigger("SatisfactionSurveyGrossScoreDelete");
                    tb.HasTrigger("TRIGGER_MED_CASE_INTERVIEW");
                });

            entity.HasIndex(e => new { e.MedCaseId, e.ProjectId, e.InterviewId, e.IndexDictId }, "IX_MED_CASE_INTERVIEW_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTimeValue)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_VALUE");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("NAME");
            entity.Property(e => e.NumericValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NUMERIC_VALUE");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Source)
                .HasMaxLength(400)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<MedCaseInterviewRecord>(entity =>
        {
            entity.ToTable("MED_CASE_INTERVIEW_RECORD");

            entity.HasIndex(e => e.IndexDictId, "IX_MED_CASE_INTERVIEW_RECORD_INDEX_DICT_ID");

            entity.HasIndex(e => e.InterviewId, "IX_MED_CASE_INTERVIEW_RECORD_INTERVIEW_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_MED_CASE_INTERVIEW_RECORD_MED_CASE_ID");

            entity.HasIndex(e => e.ProjectId, "IX_MED_CASE_INTERVIEW_RECORD_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");
            entity.Property(e => e.UpdateValue).HasColumnName("UPDATE_VALUE");
            entity.Property(e => e.UpdateWay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPDATE_WAY");
        });

        modelBuilder.Entity<MedCaseInterviewRepledView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MED_CASE_INTERVIEW_REPLED_VIEWS");

            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        });

        modelBuilder.Entity<MedCaseMedium>(entity =>
        {
            entity.ToTable("MED_CASE_MEDIA");

            entity.HasIndex(e => e.Cate, "IX_MED_CASE_MEDIA_CATE");

            entity.HasIndex(e => e.GroupId, "IX_MED_CASE_MEDIA_GROUP_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_MED_CASE_MEDIA_MED_CASE_ID");

            entity.HasIndex(e => e.UploadUserId, "IX_MED_CASE_MEDIA_UPLOAD_USER_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cate).HasColumnName("CATE");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("NAME");
            entity.Property(e => e.OriginalFilename)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("ORIGINAL_FILENAME");
            entity.Property(e => e.StoragePath)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("STORAGE_PATH");
            entity.Property(e => e.UploadTime)
                .HasColumnType("datetime")
                .HasColumnName("UPLOAD_TIME");
            entity.Property(e => e.UploadUserId).HasColumnName("UPLOAD_USER_ID");
        });

        modelBuilder.Entity<MedCaseMessage>(entity =>
        {
            entity.ToTable("MED_CASE_MESSAGE", tb => tb.HasTrigger("AddMedCaseUnreadMessage"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IsClick).HasColumnName("IS_CLICK");
            entity.Property(e => e.IsReply)
                .HasComment("0表示未回复，1表示已回复")
                .HasColumnName("IS_REPLY");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.Message)
                .IsRequired()
                .HasColumnName("MESSAGE");
            entity.Property(e => e.MessageId).HasColumnName("MESSAGE_ID");
            entity.Property(e => e.MessageType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("消息类型，text/pict/file")
                .HasColumnName("MESSAGE_TYPE");
            entity.Property(e => e.OpenId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("REMARK");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<MedCaseMessageAuth>(entity =>
        {
            entity.ToTable("MED_CASE_MESSAGE_AUTH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.DeadlineTime)
                .HasDefaultValueSql("(getdate()+(3))")
                .HasColumnType("datetime")
                .HasColumnName("DEADLINE_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.VerifyToken)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("VERIFY_TOKEN");
        });

        modelBuilder.Entity<MedCaseNode>(entity =>
        {
            entity.ToTable("MED_CASE_NODE");

            entity.HasIndex(e => e.DocNodeId, "IX_MED_CASE_NODE_DOC_NODE_ID");

            entity.HasIndex(e => e.MedCaseCateId, "IX_MED_CASE_NODE_MED_CASE_CATE_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_MED_CASE_NODE_MED_CASE_ID");

            entity.HasIndex(e => e.MedCaseRootNodeId, "IX_MED_CASE_NODE_MED_CASE_ROOT_NODE_ID");

            entity.HasIndex(e => e.NodeTime, "IX_MED_CASE_NODE_NODE_TIME");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(20)
                .HasColumnName("DISPLAY_NAME");
            entity.Property(e => e.DocNodeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOC_NODE_ID");
            entity.Property(e => e.IsUnique).HasColumnName("IS_UNIQUE");
            entity.Property(e => e.MedCaseCateId).HasColumnName("MED_CASE_CATE_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.MedCaseParentNodeId).HasColumnName("MED_CASE_PARENT_NODE_ID");
            entity.Property(e => e.MedCaseRootNodeId).HasColumnName("MED_CASE_ROOT_NODE_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("NAME");
            entity.Property(e => e.NodeTime)
                .HasColumnType("datetime")
                .HasColumnName("NODE_TIME");
        });

        modelBuilder.Entity<MedCaseNodeProperty>(entity =>
        {
            entity.ToTable("MED_CASE_NODE_PROPERTY");

            entity.HasIndex(e => e.IndexDictId, "IX_MED_CASE_NODE_PROPERTY_INDEX_DICT_ID");

            entity.HasIndex(e => e.MedCaseNodeId, "IX_MED_CASE_NODE_PROPERTY_MED_CASE_NODE_ID");

            entity.HasIndex(e => e.MedCaseRootNodeId, "IX_MED_CASE_NODE_PROPERTY_MED_CASE_ROOT_NODE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTimeValue)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_VALUE");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.MedCaseNodeId).HasColumnName("MED_CASE_NODE_ID");
            entity.Property(e => e.MedCaseRootNodeId).HasColumnName("MED_CASE_ROOT_NODE_ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.NumericName)
                .HasMaxLength(50)
                .HasColumnName("NUMERIC_NAME");
            entity.Property(e => e.NumericUnit)
                .HasMaxLength(20)
                .HasColumnName("NUMERIC_UNIT");
            entity.Property(e => e.NumericValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NUMERIC_VALUE");
            entity.Property(e => e.Tips).HasColumnName("TIPS");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<MedCasePerformLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CASE_PERFORM_LOG");

            entity.ToTable("MED_CASE_PERFORM_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.Mode)
                .HasComment("0：手动执行，1：自动执行")
                .HasColumnName("MODE");
            entity.Property(e => e.OperUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("OPER_USER_ID");
            entity.Property(e => e.OperationTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("OPERATION_TIME");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.ProjectOutinQueryId).HasColumnName("PROJECT_OUTIN_QUERY_ID");
            entity.Property(e => e.ProjectPerformLogId).HasColumnName("PROJECT_PERFORM_LOG_ID");
            entity.Property(e => e.QueryDescribe)
                .IsUnicode(false)
                .HasColumnName("QUERY_DESCRIBE");
            entity.Property(e => e.Type)
                .HasComment("0：排出，1：纳入")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<MedCaseRecord>(entity =>
        {
            entity.ToTable("MED_CASE_RECORD");

            entity.HasIndex(e => e.IndexDictId, "IX_MED_CASE_RECORD_INDEX_DICT_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_MED_CASE_RECORD_MED_CASE_ID");

            entity.HasIndex(e => e.MedCaseNodePropertyId, "IX_MED_CASE_RECORD_MED_CASE_NODE_PROPERTY_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.MedCaseNodePropertyId).HasColumnName("MED_CASE_NODE_PROPERTY_ID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");
            entity.Property(e => e.UpdateValue).HasColumnName("UPDATE_VALUE");
            entity.Property(e => e.UpdateWay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPDATE_WAY");
        });

        modelBuilder.Entity<MedCaseSmsStatusQueue>(entity =>
        {
            entity.ToTable("MED_CASE_SMS_STATUS_QUEUE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.CustomMsgId)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUSTOM_MSG_ID");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.RemindingWho).HasColumnName("REMINDING_WHO");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<MedCaseUpload1>(entity =>
        {
            entity.ToTable("MED_CASE_UPLOAD1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Diagnosis)
                .HasMaxLength(1000)
                .HasColumnName("DIAGNOSIS");
            entity.Property(e => e.DischargeDate)
                .HasColumnType("datetime")
                .HasColumnName("DISCHARGE_DATE");
            entity.Property(e => e.InpNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INP_NO");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("MESSAGE");

            entity.HasIndex(e => e.GroupId, "IX_MESSAGE_GROUP_ID");

            entity.HasIndex(e => e.GroupPatientBindApplyId, "IX_MESSAGE_GROUP_PATIENT_BIND_APPLY_ID");

            entity.HasIndex(e => e.GroupUserApplyId, "IX_MESSAGE_GROUP_USER_APPLY_ID");

            entity.HasIndex(e => e.GroupUserId, "IX_MESSAGE_GROUP_USER_ID");

            entity.HasIndex(e => e.PatientFollowUpRemindId, "IX_MESSAGE_PATIENT_FOLLOW_UP_REMIND_ID");

            entity.HasIndex(e => e.UserId, "IX_MESSAGE_USER_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.ChangContent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHANG_CONTENT");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.GroupPatientBindApplyId).HasColumnName("GROUP_PATIENT_BIND_APPLY_ID");
            entity.Property(e => e.GroupUserApplyId).HasColumnName("GROUP_USER_APPLY_ID");
            entity.Property(e => e.GroupUserId).HasColumnName("GROUP_USER_ID");
            entity.Property(e => e.PatientFollowUpRemindId).HasColumnName("PATIENT_FOLLOW_UP_REMIND_ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<MessageTitle>(entity =>
        {
            entity.ToTable("MESSAGE_TITLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<OpenVsUnion>(entity =>
        {
            entity.ToTable("OPEN_VS_UNION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OpenId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.ToTable("OPERATION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<PatientFollowRecord>(entity =>
        {
            entity.ToTable("PATIENT_FOLLOW_RECORD", tb => tb.HasTrigger("TRIGGER_PATIENT_FOLLOW_RECORD"));

            entity.HasIndex(e => e.OpenId, "IX_PATIENT_FOLLOW_RECORD_OPEN_ID");

            entity.HasIndex(e => e.UnionId, "IX_PATIENT_FOLLOW_RECORD_UNION_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.OpenId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.Status)
                .HasComment("关注:1|取消关注:0")
                .HasColumnName("STATUS");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
        });

        modelBuilder.Entity<PatientFollowUpRemind>(entity =>
        {
            entity.ToTable("PATIENT_FOLLOW_UP_REMIND");

            entity.HasIndex(e => e.GroupId, "IX_PATIENT_FOLLOW_UP_REMIND_GROUP_ID");

            entity.HasIndex(e => e.InterviewId, "IX_PATIENT_FOLLOW_UP_REMIND_INTERVIEW_ID");

            entity.HasIndex(e => e.MedCaseId, "IX_PATIENT_FOLLOW_UP_REMIND_MED_CASE_ID");

            entity.HasIndex(e => e.ProjectId, "IX_PATIENT_FOLLOW_UP_REMIND_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("PROJECT");

            entity.HasIndex(e => e.GroupId, "IX_PROJECT_GROUP_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.AddUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ADD_USER_ID");
            entity.Property(e => e.AutoBind)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AUTO_BIND");
            entity.Property(e => e.Conclusion)
                .HasMaxLength(3000)
                .HasColumnName("CONCLUSION");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IndexKeys).HasColumnName("INDEX_KEYS");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_TIME");
            entity.Property(e => e.MedCaseExpectedNum)
                .HasDefaultValueSql("((100))")
                .HasColumnName("MED_CASE_EXPECTED_NUM");
            entity.Property(e => e.MedCaseNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MED_CASE_NUM");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Summary)
                .HasMaxLength(3000)
                .HasColumnName("SUMMARY");
            entity.Property(e => e.TaskNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TASK_NUM");
        });

        modelBuilder.Entity<ProjectHistoryCase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PROJECT_HISTORY_CASE");

            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<ProjectIndexDict>(entity =>
        {
            entity.ToTable("PROJECT_INDEX_DICT");

            entity.HasIndex(e => e.IndexDictId, "IX_PROJECT_INDEX_DICT_INDEX_DICT_ID");

            entity.HasIndex(e => e.ProjectId, "IX_PROJECT_INDEX_DICT_PROJECT_ID");

            entity.HasIndex(e => e.Sort, "IX_PROJECT_INDEX_DICT_SORT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alert).HasColumnName("ALERT");
            entity.Property(e => e.ChartType)
                .HasMaxLength(10)
                .HasColumnName("CHART_TYPE");
            entity.Property(e => e.InFollowUp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IN_FOLLOW_UP");
            entity.Property(e => e.IndexDictId).HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Range).HasColumnName("RANGE");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("REMARK");
            entity.Property(e => e.ShowHiddenRule)
                .HasMaxLength(100)
                .HasColumnName("SHOW_HIDDEN_RULE");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SORT");
        });

        modelBuilder.Entity<ProjectLockMedCase>(entity =>
        {
            entity.ToTable("PROJECT_LOCK_MED_CASE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddUserId).HasColumnName("ADD_USER_ID");
            entity.Property(e => e.Addtime)
                .HasColumnType("datetime")
                .HasColumnName("ADDTIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.MedCaseId)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        });

        modelBuilder.Entity<ProjectMedCase>(entity =>
        {
            entity.ToTable("PROJECT_MED_CASE");

            entity.HasIndex(e => e.MedCaseId, "IX_PROJECT_MED_CASE_MED_CASE_ID");

            entity.HasIndex(e => e.ProjectId, "IX_PROJECT_MED_CASE_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.DateRangeFrom)
                .HasColumnType("datetime")
                .HasColumnName("DATE_RANGE_FROM");
            entity.Property(e => e.DateRangeTo)
                .HasColumnType("datetime")
                .HasColumnName("DATE_RANGE_TO");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        });

        modelBuilder.Entity<ProjectMedCaseDelRecord>(entity =>
        {
            entity.ToTable("PROJECT_MED_CASE_DEL_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.OperUserId).HasColumnName("OPER_USER_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        });

        modelBuilder.Entity<ProjectOutinQuery>(entity =>
        {
            entity.ToTable("PROJECT_OUTIN_QUERY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.AddUserId).HasColumnName("ADD_USER_ID");
            entity.Property(e => e.Describe)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("DESCRIBE");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IndexDictId)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("INDEX_DICT_ID");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Query)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("QUERY");
            entity.Property(e => e.Querybson)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("QUERYBSON");
            entity.Property(e => e.Sort).HasColumnName("SORT");
            entity.Property(e => e.SourceProjectId).HasColumnName("SOURCE_PROJECT_ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
            entity.Property(e => e.UpdateUserId).HasColumnName("UPDATE_USER_ID");
        });

        modelBuilder.Entity<ProjectPerformLog>(entity =>
        {
            entity.ToTable("PROJECT_PERFORM_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Mode)
                .HasComment("0：表示手动执行，1：表示自动执行")
                .HasColumnName("MODE");
            entity.Property(e => e.OperUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("OPER_USER_ID");
            entity.Property(e => e.PerformCaseCount).HasColumnName("PERFORM_CASE_COUNT");
            entity.Property(e => e.PerformCaseId)
                .IsRequired()
                .HasColumnName("PERFORM_CASE_ID");
            entity.Property(e => e.PerformTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PERFORM_TIME");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.ProjectOutinQueryId).HasColumnName("PROJECT_OUTIN_QUERY_ID");
            entity.Property(e => e.QueryDescribe)
                .IsUnicode(false)
                .HasColumnName("QUERY_DESCRIBE");
            entity.Property(e => e.Type)
                .HasComment("0：表示排出，1表示纳入")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<ProjectTab>(entity =>
        {
            entity.ToTable("PROJECT_TAB");

            entity.HasIndex(e => e.ProjectId, "IX_PROJECT_TAB_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Doc).HasColumnName("DOC");
            entity.Property(e => e.DocV1).HasColumnName("DOC_V1");
            entity.Property(e => e.Html).HasColumnName("HTML");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SORT");
            entity.Property(e => e.TabName)
                .HasMaxLength(50)
                .HasColumnName("TAB_NAME");
        });

        modelBuilder.Entity<ProjectTabConfig>(entity =>
        {
            entity.ToTable("PROJECT_TAB_CONFIG");

            entity.HasIndex(e => e.HtmlControlId, "IX_PROJECT_TAB_CONFIG_HTML_CONTROL_ID");

            entity.HasIndex(e => e.ProjectId, "IX_PROJECT_TAB_CONFIG_PROJECT_ID");

            entity.HasIndex(e => e.ProjectIndexDictId, "IX_PROJECT_TAB_CONFIG_PROJECT_INDEX_DICT_ID");

            entity.HasIndex(e => e.ProjectTabId, "IX_PROJECT_TAB_CONFIG_PROJECT_TAB_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ButtonName)
                .HasMaxLength(50)
                .HasColumnName("BUTTON_NAME");
            entity.Property(e => e.DateFormat)
                .HasMaxLength(50)
                .HasColumnName("DATE_FORMAT");
            entity.Property(e => e.Decimal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DECIMAL");
            entity.Property(e => e.DivWidth)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIV_WIDTH");
            entity.Property(e => e.FileViaTabId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FILE_VIA_TAB_ID");
            entity.Property(e => e.HtmlControlId).HasColumnName("HTML_CONTROL_ID");
            entity.Property(e => e.IndexDictType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("INDEX_DICT_TYPE");
            entity.Property(e => e.IsRequired)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IS_REQUIRED");
            entity.Property(e => e.MaxLength)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAX_LENGTH");
            entity.Property(e => e.MultilineRows)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MULTILINE_ROWS");
            entity.Property(e => e.NumberMax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMBER_MAX");
            entity.Property(e => e.NumberMin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMBER_MIN");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.ProjectIndexDictId).HasColumnName("PROJECT_INDEX_DICT_ID");
            entity.Property(e => e.ProjectTabId).HasColumnName("PROJECT_TAB_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.ShowCreatePdf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHOW_CREATE_PDF");
            entity.Property(e => e.ShowDownloadTemp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHOW_DOWNLOAD_TEMP");
            entity.Property(e => e.ShowTableHeader)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHOW_TABLE_HEADER");
            entity.Property(e => e.ShowType)
                .HasMaxLength(50)
                .HasColumnName("SHOW_TYPE");
            entity.Property(e => e.ShowUpload)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHOW_UPLOAD");
            entity.Property(e => e.ValidationRuleType)
                .HasMaxLength(50)
                .HasColumnName("VALIDATION_RULE_TYPE");
        });

        modelBuilder.Entity<ProjectTabQuery>(entity =>
        {
            entity.ToTable("PROJECT_TAB_QUERY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.AddUserId).HasColumnName("ADD_USER_ID");
            entity.Property(e => e.Bson)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("BSON");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.HistoryCase).HasColumnName("HISTORY_CASE");
            entity.Property(e => e.OrderKey)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('0|LAST_UPDATE_TIME|DATE|DATE')")
                .HasColumnName("ORDER_KEY");
            entity.Property(e => e.OrderMethod)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('desc')")
                .HasColumnName("ORDER_METHOD");
            entity.Property(e => e.OrderName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('更新时间')")
                .HasColumnName("ORDER_NAME");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.RowIndex)
                .IsUnicode(false)
                .HasColumnName("ROW_INDEX");
            entity.Property(e => e.RowName)
                .IsUnicode(false)
                .HasColumnName("ROW_NAME");
            entity.Property(e => e.SourceProjectId).HasColumnName("SOURCE_PROJECT_ID");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<ServerMaping>(entity =>
        {
            entity.ToTable("SERVER_MAPING");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackHostDns)
                .HasMaxLength(100)
                .HasColumnName("BACK_HOST_DNS");
            entity.Property(e => e.ServerDns)
                .HasMaxLength(100)
                .HasColumnName("SERVER_DNS");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(100)
                .HasColumnName("SERVER_IP");
            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");
        });

        modelBuilder.Entity<ServicePeriod>(entity =>
        {
            entity.ToTable("SERVICE_PERIOD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Machine)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MACHINE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.ServiceEndDate)
                .HasColumnType("date")
                .HasColumnName("SERVICE_END_DATE");
            entity.Property(e => e.ServiceStartDate)
                .HasColumnType("date")
                .HasColumnName("SERVICE_START_DATE");
        });

        modelBuilder.Entity<SmsPushTaskQueue>(entity =>
        {
            entity.ToTable("SMS_PUSH_TASK_QUEUE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.InterviewId).HasColumnName("INTERVIEW_ID");
            entity.Property(e => e.MedCaseId).HasColumnName("MED_CASE_ID");
            entity.Property(e => e.RemindingWho).HasColumnName("REMINDING_WHO");
            entity.Property(e => e.SendUserId).HasColumnName("SEND_USER_ID");
            entity.Property(e => e.Status)
                .HasComment("发短信任务是成功还是失败  0 失败 1 成功")
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<SolarLunarCalendar>(entity =>
        {
            entity.ToTable("SOLAR_LUNAR_CALENDAR");

            entity.HasIndex(e => e.Festival, "IX_SOLAR_LUNAR_CALENDAR_FESTIVAL");

            entity.HasIndex(e => e.Lunar, "IX_SOLAR_LUNAR_CALENDAR_LUNAR");

            entity.HasIndex(e => e.Solar, "IX_SOLAR_LUNAR_CALENDAR_SOLAR");

            entity.HasIndex(e => e.SolarTerms, "IX_SOLAR_LUNAR_CALENDAR_SOLAR_TERMS");

            entity.HasIndex(e => e.TraditionalFestival, "IX_SOLAR_LUNAR_CALENDAR_TRADITIONAL_FESTIVAL");

            entity.HasIndex(e => e.WeekdayFestival, "IX_SOLAR_LUNAR_CALENDAR_WEEKDAY_FESTIVAL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Festival)
                .HasMaxLength(100)
                .HasComment("节日名")
                .HasColumnName("FESTIVAL");
            entity.Property(e => e.Lunar)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("阴历")
                .HasColumnName("LUNAR");
            entity.Property(e => e.Solar)
                .HasComment("阳历")
                .HasColumnType("date")
                .HasColumnName("SOLAR");
            entity.Property(e => e.SolarTerms)
                .HasMaxLength(100)
                .HasColumnName("SOLAR_TERMS");
            entity.Property(e => e.TraditionalFestival)
                .HasMaxLength(100)
                .HasColumnName("TRADITIONAL_FESTIVAL");
            entity.Property(e => e.WeekdayFestival)
                .HasMaxLength(100)
                .HasColumnName("WEEKDAY_FESTIVAL");
        });

        modelBuilder.Entity<Statistic>(entity =>
        {
            entity.ToTable("STATISTICS");

            entity.HasIndex(e => e.ProjectId, "IX_STATISTICS_PROJECT_ID");

            entity.HasIndex(e => e.StatisticsTypeId, "IX_STATISTICS_STATISTICS_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_TIME");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.StatisticsParams).HasColumnName("STATISTICS_PARAMS");
            entity.Property(e => e.StatisticsTypeId).HasColumnName("STATISTICS_TYPE_ID");
        });

        modelBuilder.Entity<StatisticsType>(entity =>
        {
            entity.ToTable("STATISTICS_TYPE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("NAME");
            entity.Property(e => e.StatisticsFormula)
                .IsUnicode(false)
                .HasColumnName("STATISTICS_FORMULA");
            entity.Property(e => e.StatisticsParamKeys)
                .IsUnicode(false)
                .HasColumnName("STATISTICS_PARAM_KEYS");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.ToTable("TASK");

            entity.HasIndex(e => e.GroupId, "IX_TASK_GROUP_ID");

            entity.HasIndex(e => e.GroupRoleId, "IX_TASK_GROUP_ROLE_ID");

            entity.HasIndex(e => e.IndexId, "IX_TASK_INDEX_ID");

            entity.HasIndex(e => e.ProjectId, "IX_TASK_PROJECT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.ExecutionCycle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EXECUTION_CYCLE");
            entity.Property(e => e.ExecutionTimes).HasColumnName("EXECUTION_TIMES");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.GroupRoleId).HasColumnName("GROUP_ROLE_ID");
            entity.Property(e => e.IndexId).HasColumnName("INDEX_ID");
            entity.Property(e => e.LastUpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPDATE_TIME");
            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("START_TIME");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("USER");

            entity.HasIndex(e => e.ActiveGroupId, "IX_USER_ACTIVE_GROUP_ID");

            entity.HasIndex(e => e.OpenId, "IX_USER_OPEN_ID");

            entity.HasIndex(e => e.RoleId, "IX_USER_ROLE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiveGroupId).HasColumnName("ACTIVE_GROUP_ID");
            entity.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .HasColumnName("CITY");
            entity.Property(e => e.ClientAccessToken)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLIENT_ACCESS_TOKEN");
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FollowStatus)
                .HasDefaultValueSql("((1))")
                .HasComment("关注:1|取消关注:0")
                .HasColumnName("FOLLOW_STATUS");
            entity.Property(e => e.HeadImg)
                .HasMaxLength(4098)
                .IsUnicode(false)
                .HasColumnName("HEAD_IMG");
            entity.Property(e => e.HospId).HasColumnName("HOSP_ID");
            entity.Property(e => e.Hospital)
                .HasMaxLength(30)
                .HasColumnName("HOSPITAL");
            entity.Property(e => e.Language)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.LastLoginTime)
                .HasColumnType("datetime")
                .HasColumnName("LAST_LOGIN_TIME");
            entity.Property(e => e.Level)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LEVEL");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("NAME");
            entity.Property(e => e.Nickname)
                .HasMaxLength(40)
                .HasColumnName("NICKNAME");
            entity.Property(e => e.OpenId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.PcAccessToken)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_ACCESS_TOKEN");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Province)
                .HasMaxLength(10)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("REMARK");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.SecrecyAgreement)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SECRECY_AGREEMENT");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasColumnName("SECTION");
            entity.Property(e => e.Sex).HasColumnName("SEX");
            entity.Property(e => e.SubscribeTime)
                .HasColumnType("datetime")
                .HasColumnName("SUBSCRIBE_TIME");
            entity.Property(e => e.UnionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNION_ID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_TIME");
        });

        modelBuilder.Entity<UserLoginserverRecord>(entity =>
        {
            entity.ToTable("USER_LOGINSERVER_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddTime)
                .HasMaxLength(100)
                .HasColumnName("ADD_TIME");
            entity.Property(e => e.Nickname)
                .HasMaxLength(100)
                .HasColumnName("NICKNAME");
            entity.Property(e => e.OpenId)
                .HasMaxLength(100)
                .HasColumnName("OPEN_ID");
            entity.Property(e => e.ServerMapingId).HasColumnName("SERVER_MAPING_ID");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.ToTable("USER_ROLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cate)
                .HasMaxLength(50)
                .HasColumnName("CATE");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<VirtualFirstName>(entity =>
        {
            entity.ToTable("VIRTUAL_FIRST_NAME");

            entity.HasIndex(e => e.Name, "IX_VIRTUAL_FIRST_NAME_NAME").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<VirtualLastName>(entity =>
        {
            entity.ToTable("VIRTUAL_LAST_NAME");

            entity.HasIndex(e => e.Name, "IX_VIRTUAL_LAST_NAME_NAME").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<VirtualName>(entity =>
        {
            entity.ToTable("VIRTUAL_NAME");

            entity.HasIndex(e => e.Name, "IX_VIRTUAL_NAME_NAME").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
