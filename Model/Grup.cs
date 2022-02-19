using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEfCodeFirst.Model
{
    public class Grup
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Adi { get; set; } 

        public virtual ICollection<Takim> Takimlar { get; set; }
        public virtual GrupKisiVeri GrupKisiVeri { get; set; } //Kişilerin Bu grup için değerleri.
    }
}
