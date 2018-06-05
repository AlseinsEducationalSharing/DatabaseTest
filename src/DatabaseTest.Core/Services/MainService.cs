using System;
using System.Linq;
using Alsein.Utilities;
using DatabaseTest.Models;

namespace DatabaseTest.Services
{
    internal class MainService : IMainService
    {
        public IDatabaseService DatabaseService { get; set; }

        public void Main(string[] args)
        {
            var person = DatabaseService["test"].GetRepository<Person>();
            var tt = DatabaseService.ToArray();

            var adam = new Person { Name = "Adam", Age = 10 };
            var eva = new Person { Name = "Eva", Age = 15 };

            //Add
            person.Add(adam);
            person.Add(eva);

            //Change
            adam.Age = 15;
            person.Update(adam);
            person.Update(x => x.Age == 15, new Person { Age = 20 });

            //Query
            person.AsEnumerable().Select(x => $"Name={x.Name}, Age={x.Age}, Id={x.Id}").ForAll(Console.WriteLine);

            //Delete
            person.Remove(x => x.Name == "Adam");
            person.Remove(eva);
        }
    }
}