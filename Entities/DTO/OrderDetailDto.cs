using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class OrderDetailDto : IDto
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsDelivery { get; set; }

        public int TravelId { get; set; }
        public string TravelName { get; set; }


        public int OrderDetailId { get; set; }
        public decimal TotalPrice { get; set; }
        public int Count { get; set; }
        public bool IsDiscount { get; set; }
        public int DiscountPriceRate { get; set; }
    }
}
