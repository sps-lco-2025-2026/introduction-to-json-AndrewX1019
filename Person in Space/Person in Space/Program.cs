using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;


string Jstring = File.ReadAllText("data.json");
JObject J=JObject.Parse(Jstring);
Console.WriteLine(J["number"]);
Console.WriteLine(J["message"]);
Astraunauts A = JsonConvert.DeserializeObject<Astraunauts>(Jstring);
Console.WriteLine(A.number);
Console.WriteLine(A.message);
class Person
{
    public string craft;
    public string name;
    public string nationality
    {
        get
        {
            if (craft == "Tiangong")
            {
                return "Chinese";
            }
            return "European/American/Russian";
        }
    }
}

class Astraunauts
{
    public List<Person> people;
    public int number;
    public string message;
}