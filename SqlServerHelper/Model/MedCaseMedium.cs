using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseMedium
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int MedCaseId { get; set; }

    public byte? Cate { get; set; }

    public string OriginalFilename { get; set; }

    public string Name { get; set; }

    public string StoragePath { get; set; }

    public DateTime CreateTime { get; set; }

    public int UploadUserId { get; set; }

    public DateTime UploadTime { get; set; }
}
