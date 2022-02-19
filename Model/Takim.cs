using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEfCodeFirst.Model
{
    public class Takim
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Adi { get; set; }
        public int YoneticiId { get; set; }//Takımın Yöneticisi
        //public virtual Kisi Yonetici { get; set; }   //Burası sorun yapıyor.
        public virtual ICollection<Kisi> Kisiler { get; set; } //Takımdaki Kişiler
        public virtual ICollection<Grup> Gruplar { get; set; } //Takımın dahil olduğu gruplar.
    }
}
