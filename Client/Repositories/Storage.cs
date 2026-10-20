using System.Text.Json;
using System.Text.Encodings.Web;
using Client.Interfaces;
using Client.Models;

namespace Client.Repositories;

public class Storage<T> : IStorage<T> where T : class
{
    readonly JsonSerializerOptions options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    public List<T> Read(string path)
    {
        try
        {
            if (!File.Exists(path))
                return [];

            var json = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(json))
                return [];

            var data = JsonSerializer.Deserialize<List<T>>(json, options);

            return data ?? [];
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Write(string path, List<T> data)
    {
        try
        {
            var json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    internal List<Students> Read(object studentsPath)
    {
        throw new NotImplementedException();
    }
}
