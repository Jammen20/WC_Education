using System;

namespace Client.Models;

public class EducationManagers : Teachers
{
    public DateTime EmployeeDate { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} Start datumn {EmployeeDate}";
    }
}
