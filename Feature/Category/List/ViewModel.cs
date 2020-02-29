using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.List
{
    public class ViewModel
    {
        public IEnumerable<Category> Categories { get; set; }

        public ViewModel()
        {
            Categories = new List<Category>
            {
                new ViewModel.Category { Name = "MS SQL"},
                new ViewModel.Category { Name = "Obiektowość"}
            };
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
