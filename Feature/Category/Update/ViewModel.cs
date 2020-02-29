using System.ComponentModel.DataAnnotations;

namespace DDDFirst.Feature.Category.Update
{
    public class ViewModel
    {
        public CategoryInputModel Category { get; set; }
        public ViewModel()
        {
            Category = new CategoryInputModel();
        }
        public class CategoryInputModel
        {
            [Required]
            public int Id { get; set; }
            [Required]
            [Display(Name="Nazwa kategorii")]
            public string Name { get; set; }
        }
        public class CategoryReadModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }


}
