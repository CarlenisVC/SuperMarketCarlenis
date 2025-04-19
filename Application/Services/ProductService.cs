using Application.Enums;
using Application.Repositories;
using Application.Viewmodels;

namespace Application.Services
{
    public class ProductService
    { 
        public void Add(CreateProductViewModel vm)
        {           
            switch(vm.ProductType)
            {
                case (int)ProductType.FRUIT:
                    ProductRepository.Instance.Products.Fruits.Add(new ProductViewModel
                    {
                        Name = vm.Name,
                        Description = vm.Description,
                        Price = vm.Price
                    });
                    break;
                case (int)ProductType.VEGETABLE:
                    ProductRepository.Instance.Products.Vegetables.Add(new ProductViewModel
                    {
                        Name = vm.Name,
                        Description = vm.Description,
                        Price = vm.Price
                    });
                    break;
                case (int)ProductType.DAIRY_PRODUCT:
                    ProductRepository.Instance.Products.DairyProducts.Add(new ProductViewModel
                    {
                        Name = vm.Name,
                        Description = vm.Description,
                        Price = vm.Price
                    });
                    break;
            }
        }

        public ProductListViewModel GetAll()
        {
            return ProductRepository.Instance.Products;
        }

        public void Edit(EditProductViewModel vm)
        {
           
            bool found = false;

            foreach (var list in new[] {
                ProductRepository.Instance.Products.Fruits,
                ProductRepository.Instance.Products.Vegetables,
                ProductRepository.Instance.Products.DairyProducts
    })
            {
                var product = list.FirstOrDefault(p => p.Name == vm.OriginalName);
                if (product != null)
                {
                    list.Remove(product);
                    found = true;
                    break;
                }
            }

            if (!found)
                throw new Exception("Product not found");

            
            var updatedProduct = new ProductViewModel
            {
                Name = vm.Name,
                Description = vm.Description,
                Price = vm.Price
            };

            switch (vm.ProductType)
            {
                case (int)ProductType.FRUIT:
                    ProductRepository.Instance.Products.Fruits.Add(updatedProduct);
                    break;
                case (int)ProductType.VEGETABLE:
                    ProductRepository.Instance.Products.Vegetables.Add(updatedProduct);
                    break;
                case (int)ProductType.DAIRY_PRODUCT:
                    ProductRepository.Instance.Products.DairyProducts.Add(updatedProduct);
                    break;
            }
        }



        public void Delete(string name)
        {
            bool started = false;
            if(started == false)
            {
                foreach (ProductViewModel vm in ProductRepository.Instance.Products.Fruits)
                {
                    if (vm.Name == name)
                    {
                        ProductRepository.Instance.Products.Fruits.Remove(vm);
                        started = true;
                        break;
                    }
                }
            }
            
            if (started == false)
            {
                foreach (ProductViewModel vm in ProductRepository.Instance.Products.Vegetables)
                {
                    if (vm.Name == name)
                    {
                        ProductRepository.Instance.Products.Vegetables.Remove(vm);
                        started = true;
                        break;
                    }
                }
            }
            
            if (started == false)
            {
                foreach (ProductViewModel vm in ProductRepository.Instance.Products.DairyProducts)
                {
                    if (vm.Name == name)
                    {
                        ProductRepository.Instance.Products.DairyProducts.Remove(vm);
                        started = true;
                        break;
                    }
                }
            }

        }
    }
}
