using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactList.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId
        {
            get;
            set;
        }

        public string PersonFirstName
        {
            get;
            set;
        }

        public string PersonLastName
        {
            get;
            set;
        }

        public DateTime PersonBirthday
        {
            get;
            set;
        }

        [NotMapped]
        public int Age
        {
            get;
            set;
        }

    }
}
