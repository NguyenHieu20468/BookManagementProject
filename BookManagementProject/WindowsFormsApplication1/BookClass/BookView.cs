using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BookView{
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorCode { get; set; }
        public string Topic { get; set; }

        public BookView(Book book)
        {
            this.ID = book.ID;
            this.Code = book.BookCode;
            this.Name = book.BookName;
            this.AuthorCode = book.AuthorCode;
            this.Topic = book.Topic;
        }


    }
}
