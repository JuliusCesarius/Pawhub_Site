using System;
using System.ComponentModel.DataAnnotations;
namespace PetHub_Site.Models.ViewModels
{
   public  class PreregistroVM
    {
       public string UserLastName { get; set; }
       public int RegistroId { get; set; }
       public string UserCity { get; set; }
       public string UserEmail { get; set; }
       [Required]
       public string UserName { get; set; }
    }
}
