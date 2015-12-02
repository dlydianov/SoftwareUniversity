using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Book_Shop
{
    class BookShop
    {
        static void Main()
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
            Console.WriteLine(book);

            GoldenEditionBook goldBook = new GoldenEditionBook("Tiutiun", "Dimitur Dimov", 10m);
            Console.WriteLine(goldBook);
        }
    }
}
