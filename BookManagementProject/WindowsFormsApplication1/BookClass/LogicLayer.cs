using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LogicLayer
    {
        public Book[] GetStudents()
        {
            var db = new BookDatabaseEntities();
            return db.Books.ToArray();
        }

        public Book GetBook(int id)
        {
            var db = new BookDatabaseEntities();
            var bk = db.Books.Find();
            return bk;
        }
        public void CreateBook(String code, string name, string topic, string Author_code)
        {
            var bk = new Book();
            bk.BookCode = code;
            bk.BookName = name;
            bk.Topic = topic;
            bk.AuthorCode = Author_code;

            var db = new BookDatabaseEntities();
            db.Books.Add(bk);
            db.SaveChanges();
        }

        public void UpdateBook(int id, String code, string name, string topic, string Author_code)
        {
            var db = new BookDatabaseEntities();
            var bk = db.Books.Find(id);

            bk.BookCode = code;
            bk.BookName = name;
            bk.Topic = topic;
            bk.AuthorCode = Author_code;

            db.Entry(bk).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var db = new BookDatabaseEntities();
            var bk = db.Books.Find(id);

            db.Books.Remove(bk);
            db.SaveChanges();
        }
        public Author[] GetAuthors()
        {
            var db = new BookDatabaseEntities();
            return db.Authors.ToArray();
        }
    }
}
