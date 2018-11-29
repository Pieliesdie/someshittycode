using System.ComponentModel.DataAnnotations;

namespace Common
{
    public partial class Reward
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Decription { get; set; }

        //internal ICollection<Users> Users { get; set; }
    }
}
