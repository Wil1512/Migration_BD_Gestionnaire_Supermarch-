using System.ComponentModel.DataAnnotations;

namespace Migration_BD_Gestionnaire_Supermarché.Models
{
    public class Rayon
    {
        [Key]
        public int Id_Rayon { get; set; }
        public string? Nom_Rayon { get; set; }

        // Relation 1-N : Un rayon contient plusieurs produits
        public List<Produit> Produits { get; set; } = new List<Produit>();
    }
}
