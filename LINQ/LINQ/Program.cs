using System.Linq;
string[] countries = { "Pakistan", "England", "Turkey", "Palestine" }; //Data Source

var query = countries.Where(s => s.Length > 6); //Defining Query

foreach (var x in query)    //Executing Query
{
    Console.WriteLine(x);
}
Console.WriteLine("\nExecuted Query");

// Lambda expression

Func<string, bool> f = (string s) => s.Length > 6;

/// <summary>
/// Another Way of solving queries
/// </summary>

var query2 = from x in countries 
             where x.Length > 6
             select x; //Defining Query

foreach (var x in query2)    //Executing Query
{
    Console.WriteLine(x);
}

countries
    .Where(s => s.Length > 6)
    .Select(x => x + "LLLL").ToList().ForEach(x => Console.WriteLine(x)); //Defining Query

Student[] s = { new Student(1,"2","3","4"), new Student(1, "2", "3", "4") };
var query4 = s
    .Where(s => s.Id > 0)
    .Select(s => s.Name).ToList();

foreach (var x in query4)    //Executing Query
{
    Console.WriteLine(x);
}

var query5 = from x in s where x.Id > 0 select new { x.Id, x.Name };
foreach (var x in query5)    //Executing Query
{
    Console.WriteLine(x);
}
/// <summary>
/// Another Way of solving queries
/// </summary>


string[] ds = { "ABC", "BCD", "CDE", "DEF", "EFG" };
ds.Where(x => x.Contains('D')).ToList().ForEach(x => Console.WriteLine(x));

var q = from x in ds
        where x.Contains('D')
        select x;

foreach(var x in q)
{
    Console.WriteLine(x);
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Age { get; set; }

    public Student(int i, string a, string b, string c)
    {
        Id = i;
        Name = a;
        Address = b;
        Age = c;
    }

};

delegate bool MyDelegate(String s);

