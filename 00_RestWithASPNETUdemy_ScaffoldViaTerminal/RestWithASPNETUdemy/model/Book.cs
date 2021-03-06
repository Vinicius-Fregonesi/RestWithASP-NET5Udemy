using RestWithASPNETUdemy.model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.model
{
    [Table("books")]
    public class Book : BaseEntity
    {

        [Column("author")]
        public string Author { get; set; }
        [Column("launch_date")]
        public  DateTime Launch_Date { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("title")]
        public string Title { get; set; }
    }
}

