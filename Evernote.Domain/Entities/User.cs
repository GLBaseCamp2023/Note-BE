using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evernote.Domain.Entities {

    [Table("Users")]
    public class User : DbEntity {

        [Column("Email")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column("RegisterDate")]
        [MaxLength(100)]
        public DateTime RegisterDate { get; set; }

        //Password

        public List<Note> Notes { get; set; }

    }
}
