using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Domain;

namespace WebApplication1.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        [Required]
        public string NameOfMovie { get; set; }
        public int StartTime { get; set; }
        [Required]
        public int TicketPrice { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }



    }
}
