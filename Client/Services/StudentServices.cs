using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class StudentServices
{
    public static List<Students> ListAllStudents()
    {
        var storage = new Storage<Students>();
        var path = string.Concat(Environment.CurrentDirectory, "/Data/students.json");
        var students = storage.Read(path);

        return students;
    }
}
