using System.ComponentModel.DataAnnotations;

namespace Migration_BD_Gestionnaire_Supermarché.Models
{
    public class Vente
    {
        [Key]
        public int Id_Vente { get; set; }
        public int Id_Produit { get; set; }
        public DateTime Date_Vente { get; set; }
        public int Quantite_Vendue { get; set; }
        public decimal Prix_Total { get; set; }

        public Produit? Produit { get; set; }
    }
}
