using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.Entities {

    [Table("Tags")]
    public class Tag:DbEntity {

        [Column("Name")]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Note> Notes { get; set; }
        public List<TagNote> TagNotes { get; set; }

    }
}
