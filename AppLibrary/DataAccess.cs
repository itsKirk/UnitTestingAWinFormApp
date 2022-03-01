using System.Text.Json;
using UnitTestingAWinFormApp.AppLibrary.Models;

namespace AppLibrary
{
    public class DataAccess
    {
        private static List<Person> people = new();
        private static void LoadPeople()
        {
            people.Clear();
            var file = Path.GetFullPath("src/people.json");
            var fileContent = File.ReadAllText(file);
            var peopleList = JsonSerializer.Deserialize<List<Person>>(fileContent);
            if (peopleList !=null)
            {
                people.AddRange(peopleList);
            }
        }

        public static List<Person> GetPeople()
        {
            LoadPeople();
            return people;
        }
    }
}
