using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evernote.Domain.Entities {

    [Table("Tags")]
    public class Tag : DbEntity {

        [Column("Name")]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Note> Notes { get; set; }
        public List<TagNote> TagNotes { get; set; }

    }
}
