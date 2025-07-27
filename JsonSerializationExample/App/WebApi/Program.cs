
using System.Text.Json;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person { Name = "John", Age = 30 };
            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine(jsonString);

            string jsonInput = "{\"Name\":\"Alice\",\"Age\":25}";
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonInput);
            string message = $"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}";
            Console.WriteLine(message);
        }
    }
}
