using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Evernote.Domain.Entities {
    [Table("Notes")]
    public class Note : DbEntity {

        [Column("Name")]
        [MaxLength(100)]
        public string Text { get; set; }

        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }
        [Column("LastChangeDate")]
        public DateTime LastChangeDate { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<Image> Images { get; set; }

        public List<Tag> Tags { get; set; }
        public List<TagNote> TagNotes { get; set; }



    }
}
