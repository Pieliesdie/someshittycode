namespace Common
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DateTimeValidation(ErrorMessage = "Invalid date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        public uint Age { get
            {
                uint age = (uint)(DateTime.Now.Year - Birthday.Year);
                if (DateTime.Now.Month < Birthday.Month ||
                    (DateTime.Now.Month == Birthday.Month && DateTime.Now.Day < Birthday.Day))
                {
                    age--;
                }
                return age;
            } }

    }
}
