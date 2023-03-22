using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class HashTable
{
    public int Id { get; set; }

    public short HashCode { get; set; }

    public short Index { get; set; }

    public DateTime? CheckInTime { get; set; }

    public bool? NewUserCheckingIn { get; set; }

    public bool? OldUserCheckingIn { get; set; }

    public short Vcode { get; set; }
}
