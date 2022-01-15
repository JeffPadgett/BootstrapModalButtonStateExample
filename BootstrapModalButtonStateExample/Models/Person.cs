using System.ComponentModel.DataAnnotations;

namespace BootstrapModalButtonStateExample.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
