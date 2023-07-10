using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Domain
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public string IdOwner { get; set; }
        public EShopApplicationUser Owner { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

        

    }
}
