using System;
using System.Collections.Generic;

namespace StudentMVC.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }
}
