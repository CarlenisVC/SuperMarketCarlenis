namespace Application.Viewmodels
{
    public class ProductListViewModel
    {
        public List<ProductViewModel> Fruits { get; set; } = new();
        public List<ProductViewModel> Vegetables { get; set; } = new();
        public List<ProductViewModel> DairyProducts { get; set; } = new();
    }
}
