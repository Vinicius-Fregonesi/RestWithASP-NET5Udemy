using RestWithASPNETUdemy.HyperMidia;
using RestWithASPNETUdemy.HyperMidia.Abstract;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.Converter.VO
{
    
    public class PersonVO : ISupportHyperMedia
    {

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
