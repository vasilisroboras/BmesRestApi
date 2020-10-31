
using BmesRestApi.Messages.DataTransferObjects.Address;
using BmesRestApi.Messages.DataTransferObjects.Cart;
using BmesRestApi.Messages.DataTransferObjects.Customer;
using BmesRestApi.Messages.DataTransferObjects.Order;
using BmesRestApi.Messages.DataTransferObjects.Product;
using BmesRestApi.Messages.DataTransferObjects.Shared;
using BmesRestApi.Models.Address;
using BmesRestApi.Models.Cart;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Order;
using BmesRestApi.Models.Product;
using BmesRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Messages
{
    public class MessageMapper
    {
        public Brand MapToBrand(BrandDto brandDto)
        {
            var brand = new Brand
            {
                Id = brandDto.Id,
                Name = brandDto.Name,
                Slug = brandDto.Slug,
                Description = brandDto.Description,
                MetaDescription = brandDto.MetaDescription,
                MetaKeywords = brandDto.MetaKeywords,
                BrandStatus = (BrandStatus)brandDto.BrandStatus,
                ModifiedDate = brandDto.ModifiedDate,
                IsDeleted = brandDto.IsDeleted
            };

            return brand;
        }

        public BrandDto MapToBrandDto(Brand brand)
        {
            var brandDto = new BrandDto();

            if(brand !=null)
            {
                brandDto.Id = brand.Id;
                brandDto.Name = brand.Name;
                brandDto.Slug = brand.Slug;
                brandDto.Description = brand.Description;
                brandDto.MetaDescription = brand.MetaDescription;
                brandDto.MetaKeywords = brand.MetaKeywords;
                brandDto.BrandStatus = (int)brand.BrandStatus;
                brandDto.ModifiedDate = brand.ModifiedDate;
                brandDto.IsDeleted = brand.IsDeleted;
            }
            return brandDto;
        }

        public Category MapToCategory(CategoryDto categoryDto)
        {
            var category = new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Slug = categoryDto.Slug,
                Description = categoryDto.Description,
                MetaDescription = categoryDto.MetaDescription,
                MetaKeywords = categoryDto.MetaKeywords,
                CategoryStatus = (CategoryStatus)categoryDto.CategoryStatus,
                ModifiedDate = categoryDto.ModifiedDate,
                IsDeleted = categoryDto.IsDeleted

            };
            return category;
        }
        public CategoryDto MapToCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug,
                Description = category.Description,
                MetaDescription = category.MetaDescription,
                MetaKeywords = category.MetaKeywords,
                CategoryStatus = (int)category.CategoryStatus,
                ModifiedDate = category.ModifiedDate,
                IsDeleted = category.IsDeleted
            };
            
        }

        public Product MapToProduct(ProductDto productDto)
        {
            var product = new Product
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Slug = productDto.Slug,
                Description = productDto.Description,
                MetaDescription = productDto.MetaDescription,
                MetaKeywords = productDto.MetaKeywords,
                SKU = productDto.SKU,
                Model = productDto.Model,
                Price = productDto.Price,
                SalePrice = productDto.SalePrice,
                OldPrice = productDto.OldPrice,
                ImageUrl = productDto.ImageUrl,
                QuantityInStock = productDto.QuantityInStock,
                IsBestseller = productDto.IsBestseller,
                CategoryId = productDto.CategoryId,
                ProductStatus = (ProductStatus)productDto.ProductStatus,
                CreateDate = productDto.CreateDate,
                ModifiedDate = productDto.ModifiedDate,
                IsDeleted = productDto.IsDeleted

            };
            return product;
        }
        public ProductDto MapToProductDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Slug = product.Slug,
                Description = product.Description,
                MetaDescription = product.MetaDescription,
                MetaKeywords = product.MetaKeywords,
                SKU = product.SKU,
                Model = product.Model,
                Price = product.Price,
                SalePrice = product.SalePrice,
                OldPrice = product.OldPrice,
                ImageUrl = product.ImageUrl,
                QuantityInStock = product.QuantityInStock,
                IsBestseller = product.IsBestseller,
                CategoryId = product.CategoryId,
                ProductStatus = (int)product.ProductStatus,
                CreateDate = product.CreateDate,
                ModifiedDate = product.ModifiedDate,
                IsDeleted = product.IsDeleted
            };
            
        }
        public CartDto MapToCartDto(Cart cart)
        {
            var cartDto = new CartDto();
            if (cart != null)
            {
                cartDto.Id = cart.Id;
                cartDto.CreateDate = cart.CreateDate;
                cartDto.ModifiedDate = cart.ModifiedDate;
                cartDto.IsDeleted = cart.IsDeleted;
                cartDto.UniqueCartId = cart.UniqueCartId;
                cartDto.CartStatus = (int)cart.CartStatus;

            }
            return cartDto;
        }
        public Cart MapToBrand(CartDto cartDto)
        {

            var cart = new Cart();

            if(cartDto!=null)
            {
                cart.Id = cartDto.Id;
                cart.CreateDate = cartDto.CreateDate;
                cart.ModifiedDate = cartDto.ModifiedDate;
                cart.IsDeleted = cartDto.IsDeleted;
                cart.UniqueCartId = cartDto.UniqueCartId;
                cart.CartStatus = (CartStatus)cartDto.CartStatus;
            }
            return cart;
        }
        

        public CartItemDto MapToCartItemDto(CartItem cartItem)
        {
            CartItemDto cartItemDto = null;

            if (cartItem.Product != null)
            {
                var productDto = MapToProductDto(cartItem.Product);

                cartItemDto = new CartItemDto
                {
                    Id = cartItem.Id,
                    CartId = cartItem.CartId,
                    Product = productDto,
                    Quantity = cartItem.Quantity
                };
            }

            return cartItemDto;
        }
        public CartItem MapToCartItem(CartItemDto cartItemDto)
        {
            return new CartItem
            {
                CartId = cartItemDto.CartId,
                ProductId = cartItemDto.Product.Id,
                Quantity = cartItemDto.Quantity

            };
        }

        public AddressDto MapToAddressDto(Address address)
        {
            AddressDto addressDto = null;
            if(address != null)
            {
                addressDto = new AddressDto
                {
                    Id = address.Id,
                    Name = address.Name,
                    AddressLine1 = address.AddressLine1,
                    AddressLine2 = address.AddressLine2,
                    City = address.City,
                    Country = address.Country,
                    State = address.State,
                    ZipCode = address.ZipCode,
                    CreateDate = address.CreateDate,
                    ModifiedDate = address.ModifiedDate,
                    IsDeleted = address.IsDeleted
            };
            }
            return addressDto;
        }

        public Address MapToAddress(AddressDto addressDto)
        {
            Address address = null;
            if(addressDto != null)
            {
                addressDto = new AddressDto
                {
                    Id = addressDto.Id,
                    Name = addressDto.Name,
                    AddressLine1 = addressDto.AddressLine1,
                    AddressLine2 = addressDto.AddressLine2,
                    City = addressDto.City,
                    Country = addressDto.Country,
                    State = addressDto.State,
                    ZipCode = addressDto.ZipCode,
                    CreateDate = addressDto.CreateDate,
                    ModifiedDate = addressDto.ModifiedDate,
                    IsDeleted = addressDto.IsDeleted
                };
            }
            return address;
        }
        public CustomerDto MapToCustomerDto(Customer customer)
        {
            var customerDto = new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.Person.FirstName,
                MiddleName = customer.Person.MiddleName,
                LastName = customer.Person.LastName,
                EmailAddress = customer.Person.EmailAddress,
                PhoneNumber = customer.Person.PhoneNumber,
                Gender = (int)customer.Person.Gender,
                DateOfBirth = customer.Person.DateOfBirth,
                CreateDate = customer.CreateDate,
                ModifiedDate = customer.ModifiedDate,
                IsDeleted = customer.IsDeleted
            };

            return customerDto;
        }
        public Customer MapToCustomer(CustomerDto customerDto)
        {
            var person = new Person
            {
                Id = customerDto.Id,
                FirstName = customerDto.FirstName,
                MiddleName = customerDto.MiddleName,
                LastName = customerDto.LastName,
                EmailAddress = customerDto.EmailAddress,
                PhoneNumber = customerDto.PhoneNumber,
                Gender = (Gender)customerDto.Gender,
                DateOfBirth = customerDto.DateOfBirth,
                CreateDate = customerDto.CreateDate,
                ModifiedDate = customerDto.ModifiedDate,
                IsDeleted = customerDto.IsDeleted
            };

            return new Customer
            {
                Id = customerDto.Id,
                Person = person
            };
        }
        public PersonDto MapToPersonDto(Person person)
        {
            var personDto = new PersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                EmailAddress = person.EmailAddress,
                PhoneNumber = person.PhoneNumber,
                Gender = (int)person.Gender,
                DateOfBirth = person.DateOfBirth,
                CreateDate = person.CreateDate,
                ModifiedDate = person.ModifiedDate,
                IsDeleted = person.IsDeleted
            };

            return personDto;
        }

        public Person MapToPerson(PersonDto personDto)
        {
            return new Person
            {
                Id = personDto.Id,
                FirstName = personDto.FirstName,
                MiddleName = personDto.MiddleName,
                LastName = personDto.LastName,
                EmailAddress = personDto.EmailAddress,
                PhoneNumber = personDto.PhoneNumber,
                Gender = (Gender)personDto.Gender,
                DateOfBirth = personDto.DateOfBirth,
                CreateDate = personDto.CreateDate,
                ModifiedDate = personDto.ModifiedDate,
                IsDeleted = personDto.IsDeleted
            };
        }
        public OrderDto MapToOrderDto(Order order)
        {
            var orderDto = new OrderDto
            {
                Id = order.Id,
                OrderTotal = order.OrderTotal,
                OrderItemTotal = order.OrderTotal,
                ShippingCharge = order.ShippingCharge,
                CustomerId = order.CustomerId,
                OrderStatus = (int)order.OrderStatus,
                CreateDate = order.CreateDate,
                ModifiedDate = order.ModifiedDate,
                IsDeleted = order.IsDeleted
            };

            return orderDto;
        }

        public Order MapToOrder(OrderDto orderDto)
        {
            return new Order
            {
                Id = orderDto.Id,
                OrderTotal = orderDto.OrderTotal,
                OrderItemTotal = orderDto.OrderTotal,
                ShippingCharge = orderDto.ShippingCharge,
                CustomerId = orderDto.CustomerId,
                OrderStatus = (OrderStatus)orderDto.OrderStatus,
                CreateDate = orderDto.CreateDate,
                ModifiedDate = orderDto.ModifiedDate,
                IsDeleted = orderDto.IsDeleted
            };
        }

        public OrderItemDto MapToOrderItemDto(OrderItem orderItem)
        {
            OrderItemDto orderItemDto = null;

            if (orderItem?.Product != null)
            {
                var productDto = MapToProductDto(orderItem.Product);

                orderItemDto = new OrderItemDto
                {
                    Id = orderItem.Id,
                    OrderId = orderItem.OrderId,
                    Product = productDto,
                    Quantity = orderItem.Quantity
                };
            }

            return orderItemDto;
        }

        public OrderItem MapToOrderItem(OrderItemDto orderItemDto)
        {
            return new OrderItem
            {
                OrderId = orderItemDto.OrderId,
                ProductId = orderItemDto.Product.Id,
                Quantity = orderItemDto.Quantity
            };
        }






        public List<BrandDto> MapToBrandDtos(IEnumerable<Brand> brands)
        {
            var brandDtos = new List<BrandDto>();
            foreach (var brand in brands)
            {
                var brandDto = MapToBrandDto(brand);
                brandDtos.Add(brandDto);


            }
            return brandDtos;
        }
        public List<CategoryDto> MapToCategoryDtos(IEnumerable<Category> categories)
        {
            var categoryDtos = new List<CategoryDto>();
            foreach (var category in categories)
            {
                var categoryDto = MapToCategoryDto(category);
                categoryDtos.Add(categoryDto);

            }
            return categoryDtos;
        }
        public List<ProductDto> MapToProductDtos(IEnumerable<Product> products)
        {
            var productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                var productDto = MapToProductDto(product);
                productDtos.Add(productDto);

            }
            return productDtos;
        }

        public List<CartItemDto> MapToCartItemDtos(IEnumerable<CartItem> cartItems)
        {
            var cartItemDtos = new List<CartItemDto>();
            foreach(var cartItem in cartItems)
            {
                var cartItemDto = MapToCartItemDto(cartItem);
                cartItemDtos.Add(cartItemDto);
            }
            return cartItemDtos;
        }
        public List<AddressDto> MapToAddressDtos(IEnumerable<Address> addresses)
        {
            var addressDtos = new List<AddressDto>();
            foreach (var address in addresses)
            {
                var addressDto = MapToAddressDto(address);
                addressDtos.Add(addressDto);
            }
            return addressDtos;
        }
    }
}
