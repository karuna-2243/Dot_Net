﻿using System;
using System.Collections.Generic;

namespace StudentMVC1.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }
}
