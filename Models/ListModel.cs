using System;
using System.ComponentModel;

namespace mvc.Models
{
    public class ListModel
    {
        [DisplayName("Lp.")]
        public int ListId { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DisplayName("Opis")]
        public string Description { get; set; }

        [DisplayName("Czy kupione ?")]
        public bool Done { get; set; }
    }
}