using Application.Enums;
using Application.Repositories;
using Application.Services;
using Application.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket2024G34.Tests
{
    public class ProductServiceTests
    {
        private readonly ProductService _service;

        public ProductServiceTests()
        {
            _service = new ProductService();

            
            ProductRepository.Instance.Products = new ProductListViewModel();
        }

        [Fact]
        public void Add_ShouldAddProductToCorrectCategory()
        {
            
            var product = new CreateProductViewModel
            {
                Name = "Banana",
                Description = "Fresh yellow banana",
                Price = 10.5,
                ProductType = (int)ProductType.FRUIT
            };

            
            _service.Add(product);

           
            Assert.Single(ProductRepository.Instance.Products.Fruits);
            Assert.Equal("Banana", ProductRepository.Instance.Products.Fruits[0].Name);
        }

        [Fact]
        public void Delete_ShouldRemoveProductFromList()
        {
            
            _service.Add(new CreateProductViewModel
            {
                Name = "Tomato",
                Description = "Red and ripe",
                Price = 5,
                ProductType = (int)ProductType.VEGETABLE
            });

            
            _service.Delete("Tomato");

            
            Assert.Empty(ProductRepository.Instance.Products.Vegetables);
        }

        [Fact]
        public void Edit_ShouldUpdateProductCategory()
        {
            
            _service.Add(new CreateProductViewModel
            {
                Name = "Cheese",
                Description = "Creamy cheese",
                Price = 25,
                ProductType = (int)ProductType.DAIRY_PRODUCT
            });

            var editModel = new EditProductViewModel
            {
                OriginalName = "Cheese",
                Name = "Cheese Deluxe",
                Description = "Aged cheese",
                Price = 30,
                ProductType = (int)ProductType.FRUIT 
            };

           
            _service.Edit(editModel);

            
            Assert.Empty(ProductRepository.Instance.Products.DairyProducts);
            Assert.Single(ProductRepository.Instance.Products.Fruits);
            Assert.Equal("Cheese Deluxe", ProductRepository.Instance.Products.Fruits[0].Name);
        }
    }
}
