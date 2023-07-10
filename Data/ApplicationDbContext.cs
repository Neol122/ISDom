using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;
using WebApplication1.Models.Domain;



namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext<EShopApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Ticket>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<TicketInShoppingCart>()
                .HasKey(z => new { z.IdTicket, z.IdShoppingCart });

            builder.Entity<TicketInShoppingCart>()
                .HasOne(z => z.ticket)
                .WithMany(z => z.TicketInShoppingCarts)
                .HasForeignKey(z => z.IdShoppingCart);

            builder.Entity<TicketInShoppingCart>()
                .HasOne(z => z.Shoppingcart)
                .WithMany(z => z.TicketInShoppingCarts)
                .HasForeignKey(z => z.IdTicket);

            builder.Entity<ShoppingCart>()
                .HasOne<EShopApplicationUser>(z => z.Owner)
                .WithOne(z => z.UserCart)
                .HasForeignKey<ShoppingCart>(z => z.IdOwner);
           
        }
    }
}
