using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Domain
{
    public class TicketInShoppingCart
    {
        public Guid IdTicket { get; set; }
        public Guid IdShoppingCart { get; set; }
        public Ticket ticket { get; set; }
        public ShoppingCart Shoppingcart { get; set; }


        public int Quantity { get; set; }

    }
}
