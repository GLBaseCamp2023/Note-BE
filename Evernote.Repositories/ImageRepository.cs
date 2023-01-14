using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Entities;
using Evernote.Repositories.Abstract;
using Evernote.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace Evernote.Repositories {
    internal class ImageRepository : DbRepository<Image>, IImageRepository {
        public ImageRepository(DbContext context) : base(context) {
        }
    }
}
