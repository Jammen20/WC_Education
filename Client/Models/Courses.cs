using System;

namespace Client.Models;

public class Courses

{
    public string CourseNumber { get; set; } = "";
    public string Title { get; set; } = "";
    public int Length { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType CourseType { get; set; }

    public override string ToString()
    {
        return $" Kursnummer {CourseNumber}\n Title {Title}\n Längd {Length} veckor\n Startdatum {StartDate}\n Slutdatum {EndDate}\n KursTyp {CourseType}\n ";
    }

}
