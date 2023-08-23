using System.ComponentModel.DataAnnotations;

namespace AgLeather.Shop.UI.Models.RequestModels
{
    public class CreateCategoryVM
    {
        [Display(Name = "Kategori adı")]
        public string CategoryName { get; set; }
    }
}
