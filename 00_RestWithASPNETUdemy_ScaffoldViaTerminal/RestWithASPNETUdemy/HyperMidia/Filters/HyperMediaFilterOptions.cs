using RestWithASPNETUdemy.HyperMidia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.HyperMidia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentReponseEnricherList { get; set; } = new List<IResponseEnricher>();

    }
}
