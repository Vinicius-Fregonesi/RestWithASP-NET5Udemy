using System.Collections.Generic;

namespace RestWithASPNETUdemy.HyperMidia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
