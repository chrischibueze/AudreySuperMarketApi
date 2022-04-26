using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudreySuperMarket.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }


    }
}
