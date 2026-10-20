using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class CourseServices
{
    public static List<Courses> ListAllCourses()
    {
        var storage = new Storage<Courses>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/courses.json");
        var courses = storage.Read(path);

        return courses;
    }
}
