using System.ComponentModel.DataAnnotations;

namespace Migration_BD_Gestionnaire_Supermarché.Models
{
    public class Produit
    {
            [Key]
            public int Id_Produit { get; set; }
            public string? Nom_Produit { get; set; }
            public decimal Prix_Unitaire { get; set; }
            public int Quantite_Stock { get; set; }

            // Clé étrangère vers Rayon
            public int Id_Rayon { get; set; }
            public Rayon? Rayon { get; set; }
        
    }
}
