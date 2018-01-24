using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyXamarin.Models
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get
            {
                return $"http://lorempixel.com/200/200/people/{UserId}";
            }
        }
    }
}
