namespace UnitTestingAWinFormApp.AppLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Name 
        { 
            get => $"{FirstName} {LastName}"; 
        }
    }
}
