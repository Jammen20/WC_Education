using System;
using System.Runtime.InteropServices;

namespace Client.Models;

public class Teachers : Students
{
    public string Knowledge { get; set; } = "";
    public List<string> Courses { get; set; } = [];

    public override string ToString()
    {
        return $"{base.ToString()} Kunskapsområde {Knowledge} Kurser {Courses}";
    }
}
