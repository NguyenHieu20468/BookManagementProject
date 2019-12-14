using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BookManagement
    {
        public Book[] searchingName(string name)
        {
            var db = new BookDatabaseEntities();
            var result = db.Books.Where(b => b.BookName == name).ToArray();
            return result;
        }
    }
}
