using System;
namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    public interface IReportDetail
    {
        string adress { get; set; }
        string age { get; set; }
        string characteristics { get; set; }
        string dateEvent { get; set; }
        string name { get; set; }
        System.Collections.Generic.List<PetHub_Site.Models.Picture> pics { get; set; }
    }
}
