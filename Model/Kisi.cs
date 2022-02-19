using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEfCodeFirst.Model
{
    public class Kisi
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Adi { get; set; }
        public int Soyadi { get; set; }

        public int TakimId { get; set; } //Kişinin takımı
        public virtual Takim Takim{ get; set; } 
    }
}
