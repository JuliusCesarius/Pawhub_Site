using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class PetCounterVM
    {
        public short Comments { get; set; }
        public short Following { get; set; }
        public short Friends { get; set; }
        public short Likes { get; set; }
        public Guid PetId { get; set; }
        public short Rates { get; set; }
        public short Views { get; set; }
    }
}
