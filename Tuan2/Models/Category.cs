using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tuan2.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }
    }
}
