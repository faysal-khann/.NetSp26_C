using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public double Cgpa { get; set; }
}
