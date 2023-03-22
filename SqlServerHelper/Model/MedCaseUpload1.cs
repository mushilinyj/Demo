using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseUpload1
{
    public int Id { get; set; }

    public string InpNo { get; set; }

    public string Diagnosis { get; set; }

    public DateTime? DischargeDate { get; set; }
}
