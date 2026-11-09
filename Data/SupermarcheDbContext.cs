
using Microsoft.EntityFrameworkCore;
using Migration_BD_Gestionnaire_Supermarché.Models;
using System.Collections.Generic;

namespace Migration_BD_Gestionnaire_Supermarché.Data
{
    public class SupermarcheDbContext : DbContext
    {
        public SupermarcheDbContext(DbContextOptions<SupermarcheDbContext> options) : base(options) { }

        public DbSet<Rayon> Rayons { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Vente> Ventes { get; set; }
    }
}
