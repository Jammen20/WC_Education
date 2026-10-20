using System;

namespace Client.Models;

public class Administrators : EducationManagers
{
    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}
