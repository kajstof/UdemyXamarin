using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyXamarin.Models
{
    class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Period { get => $"{CheckIn.ToString("MMM d, yyyy")} - {CheckOut.ToString("MMM d, yyyy")}"; }
    }
}
