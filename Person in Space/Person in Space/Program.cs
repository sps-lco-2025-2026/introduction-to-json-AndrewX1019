using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;


string Jstring = File.ReadAllText("data.json");

JObject J=JObject.Parse(Jstring);
Console.WriteLine(J["number"]);
Console.WriteLine(J["message"]);
Console.WriteLine(J["craft"]);//keys

Astraunauts A = JsonConvert.DeserializeObject<Astraunauts>(Jstring);
Console.WriteLine(A.number);
Console.WriteLine(A.message);

Debug.Assert(A.station_count[0]=="ISS");
Debug.Assert(A.station_count[1]=="Tiangong");

class Person
{
    public string craft;
    public string name;
    public string nationality => craft=="Tiangong"?"CHN":"US OR EU OR RU";
}

class Astraunauts
{
    public List<Person> people;
    public int number;
    public string message;
    public List<string> station_count
    {
        get
        {
            List<string> ans = new List<string>();
            foreach(Person p in people)
            {
                if (!ans.Any(x => x == p.craft))
                {
                    ans.Add(p.craft);
                }
            }
            return ans;
        }
    }
}