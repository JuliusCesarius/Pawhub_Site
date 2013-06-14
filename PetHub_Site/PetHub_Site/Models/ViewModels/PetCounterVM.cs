using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class PetCounterVM
    {
        short Comments { get; set; }
        short Following { get; set; }
        short Friends { get; set; }
        short Likes { get; set; }
        Guid PetId { get; set; }
        short Rates { get; set; }
        short Views { get; set; }
    }
}
