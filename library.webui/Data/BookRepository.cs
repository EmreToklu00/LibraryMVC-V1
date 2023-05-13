using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library.webui.Models;

namespace library.webui.Data
{
    public class BookRepository
    {
        private static List<Book> _books = null;
        static string imageUrl1 = "https://e7.pngegg.com/pngimages/342/861/png-clipart-book-book.png";
        static string imageUrl2 = "https://www.pngmart.com/files/21/Book-Stack-PNG-Background-Image.png";
        static BookRepository()
        {
            _books = new List<Book>
            {
                new Book {Id=1,Name="macera kitabı",Price=30,Description="macera dolu kitap", ImageUrl=imageUrl1,CategoryId=1},
                new Book {Id=2,Name="macera kitabı 2",Price=40,Description=" macera dolu kitap", ImageUrl=imageUrl1,CategoryId=1},
                new Book {Id=3,Name="macera kitabı 3",Price=50,Description=" macera dolu kitap", ImageUrl=imageUrl1,CategoryId=1},
                new Book {Id=4,Name="macera kitabı 4",Price=70,Description=" macera dolu kitap", ImageUrl=imageUrl1,CategoryId=1},
                new Book {Id=5,Name="macera kitabı 5",Price=70,Description=" macera dolu kitap", ImageUrl=imageUrl1,CategoryId=1},
                new Book {Id=6,Name="deneme kitapı 6",Price=30,Description="deneme yazısı", ImageUrl=imageUrl2,CategoryId=2},
                new Book {Id=7,Name="deneme kitapı 7",Price=40,Description=" deneme yazısı", ImageUrl=imageUrl2,CategoryId=2},
                new Book {Id=8,Name="deneme kitapı 8",Price=50,Description=" deneme yazısı", ImageUrl=imageUrl2,CategoryId=2},
                new Book {Id=9,Name="deneme kitapı 9",Price=70,Description=" deneme yazısı", ImageUrl=imageUrl2,CategoryId=2}
            };
        }
        public static List<Book> Books
        {
            get
            {
                return _books;
            }
        }
        public static Book GetBookById(int id)
        {
            return _books.FirstOrDefault(p => p.Id == id);
        }

        public static void AddProduct(Book book)
        {
            _books.Add(book);
        }

        public static void EditBook(Book book)
        {
            foreach (var b in _books)
            {
                if (b.Id == book.Id)
                {
                    b.Name = book.Name;
                    b.Price = book.Price;
                    b.ImageUrl = book.ImageUrl;
                    b.Description = book.Description;
                    b.CategoryId = book.CategoryId;
                }
            }
        }
        public static void Delete(int Id)
        {
            var book = GetBookById(Id);
            if (book != null)
            {
                _books.Remove(book);
            }

        }



    }
}