using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BookView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorCode { get; set; }
        public string Topic { get; set; }

        public BookView(Book bk)
        {
            this.Id = bk.ID;
            this.Code = bk.BookCode;
            this.Name = bk.BookName;
            this.AuthorCode = bk.AuthorCode;
            this.Topic = bk.Topic;
        }
    }
}
