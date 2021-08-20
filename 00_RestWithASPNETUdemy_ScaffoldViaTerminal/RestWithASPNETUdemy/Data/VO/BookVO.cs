using RestWithASPNETUdemy.HyperMidia;
using RestWithASPNETUdemy.HyperMidia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.VO
{
    public class BookVO : ISupportHyperMedia
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public  DateTime Launch_Date { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

