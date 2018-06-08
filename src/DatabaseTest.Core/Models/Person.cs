namespace DatabaseTest.Models
{
    public class Person : IModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}