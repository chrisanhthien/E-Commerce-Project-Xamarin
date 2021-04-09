using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShopProject.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public MainViewModel()
        {
            Products = GetProducts();
            MenuList = GetMenus();
        }

        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }


        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private ObservableCollection<Menu> menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }

        public void ShowDetails()
        {
            var page = new DetailsPage() { BindingContext = new DetailsViewModel { SelectedProduct = SelectedProduct } };
            App.Current.MainPage.Navigation.PushAsync(page);
        }

        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Icon = "order.png", Name = "My Order"},
                new Menu { Icon = "shopping.png", Name = "Shopping Cart"},
                new Menu { Icon = "settings.png", Name = "Settings"}
            };
        }

        private ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                new Product { Name = "Hilfi Watch", Price = 789.99f, Image = "charlesWatch.png", Model = "Model 2011", Rating = 4.5, Views = 4.5, Description = "This is the test desciption for the product and you can read more about the product description in this part"},
                new Product { Name = "Gold Watch", Price = 697.99f, Image = "johnWatch.png", Model = "Model 2009", Rating = 4.5, Views = 4.5, Description = "This is the test desciption for the product and you can read more about the product description in this part"},
                new Product { Name = "Pierre LD Watch", Price = 897.99f, Image = "marekWatch.png", Model = "Model 2070", Rating = 4.5, Views = 4.5, Description = "This is the test desciption for the product and you can read more about the product description in this part"},
                new Product { Name = "Omega RD Watch", Price = 567.99f, Image = "rutgeWatch.png", Model = "Model 1997", Rating = 4.5, Views = 4.5, Description = "This is the test desciption for the product and you can read more about the product description in this part"},
            };
        }


        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public double Rating { get; set; }
        public double Views { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }

    public class Menu
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
