using System.ComponentModel.DataAnnotations;

namespace DatabaseTest
{
    public abstract class ModelBase
    {
        [Key]
        public string Id { get; set; }
    }
}