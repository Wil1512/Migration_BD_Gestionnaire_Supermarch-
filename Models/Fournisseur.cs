using System.ComponentModel.DataAnnotations;

namespace Migration_BD_Gestionnaire_Supermarché.Models
{
    public class Fournisseur
    {
        [Key]
        public int Id_Fournisseur { get; set; }
        public string? Nom_Fournisseur { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
    }
}
