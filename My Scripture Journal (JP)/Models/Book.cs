using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace My_Scripture_Journal__JP_.Models
{
    public class Book
    {
        public int ID { get; set; }

        public string BookName { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public int Chapter { get; set; }
        public int Verse { get; set; }

        public string Notes { get; set; }

    }
}
