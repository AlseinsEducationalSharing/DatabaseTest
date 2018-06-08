using System.ComponentModel.DataAnnotations;

namespace DatabaseTest.Common
{
    public class ModelBase : IModel
    {
        [Key]
        public string Id { get; set; }
    }
}