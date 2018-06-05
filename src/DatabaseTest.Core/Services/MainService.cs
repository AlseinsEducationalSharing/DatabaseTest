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
            var testModel = DatabaseService["test"].GetRepository<Person>();
            var tt = DatabaseService.ToArray();

            var adam = new Person { Name = "Adam", Age = 10 };
            var eva = new Person { Name = "Eva", Age = 15 };

            //Add
            testModel.Add(adam);
            testModel.Add(eva);

            //Change
            adam.Age = 15;
            testModel.Update(adam);
            testModel.Update(x => x.Age == 15, new Person { Age = 20 });

            //Query
            testModel.AsEnumerable().Select(x => $"Name={x.Name}, Age={x.Age}, Id={x.Id}").ForAll(Console.WriteLine);

            //Delete
            testModel.Remove(x => x.Name == "Adam");
            testModel.Remove(eva);
        }
    }
}