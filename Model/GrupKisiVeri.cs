using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEfCodeFirst.Model
{
    public class GrupKisiVeri
    {

        //Kişilerin o gruptaki verileri..
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GrupId { get; set; }
        public virtual Grup Grup { get; set; }
        public int KisiId { get; set; }
        public virtual Kisi Kisi { get; set; }
        public int Puan { get; set; }
        public int Derece { get; set; }

    }
}
