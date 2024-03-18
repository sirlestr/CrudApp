using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class People
    {
        public int Id { get; set; }

        [Display(Name ="Jméno")]
        public  string FirstName { get; set; }

        [Display(Name = "Příjmení")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Je aktivní?")]
        public bool IsActive { get; set; }


    }
}
