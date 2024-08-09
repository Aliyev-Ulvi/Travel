using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }

        public string TravelName { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public string ImageUrl { get; set; }
    }
}
