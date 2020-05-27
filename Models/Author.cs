using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheOnlineBookStore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
