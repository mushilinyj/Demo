using SqlServerHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerHelper.Service;
public class CityService
{
    public static List<City> FindAll()
    {
        using MedioContext context = new();
        return context.Cities.ToList();
    }

    public static City FindOneById(int id)
    {
        using MedioContext context = new();
        return context.Cities.FirstOrDefault(c => c.Id == id);
    }
    public static City CreateOne(string code, string name)
    {
        using MedioContext context = new();
        City city = new()
        {
            AreaCode = code,
            Name = name
        };
        context.Cities.Add(city);
        context.SaveChanges();
        return city;
    }
}
