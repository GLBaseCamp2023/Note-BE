using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.Entities {


    [Table("Images")]
    public class Image:DbEntity {

        [Column("Path")]
        public string Path { get; set; }

        public Guid NoteId { get; set; }
        public Note Note { get; set; }


    }
}
