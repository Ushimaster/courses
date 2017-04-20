namespace Courses._20483.UI.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using ProductServices;

    public class MainWindowViewModel: ViewModel
    {
        private string productName;
        private string productDescription;
        private int productStock;
        private decimal productPrice;
        private Category category;

        private ObservableCollection<Product> products;
        private ObservableCollection<Category> categories;

        private readonly ProductServiceClient client;

        private ICommand saveProductCommand;

        public MainWindowViewModel()
        {
            this.client = new ProductServiceClient();
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                this.productName = value;
                this.RaiseOnPropertyChanged( "ProductName" );
            }
        }

        public string ProductDescription
        {
            get { return this.productDescription; }
            set
            {
                this.productDescription = value;
                this.RaiseOnPropertyChanged( "ProductDescription" );
            }
        }

        public decimal ProductPrice
        {
            get { return this.productPrice; }
            set
            {
                this.productPrice = value;
                this.RaiseOnPropertyChanged( "ProductPrice" );
            }
        }

        public int ProductStock
        {
            get { return this.productStock; }
            set
            {
                this.productStock = value;
                this.RaiseOnPropertyChanged( "ProductStock" );
            }
        }

        public Category Category
        {
            get { return this.category; }
            set
            {
                this.category = value;
                this.RaiseOnPropertyChanged( "Category" );
            }
        }

        public ObservableCollection<Product> Products
        {
            get
            {
                if( this.products == null )
                {
                    this.products = new ObservableCollection<Product>( this.client.GetProducts().ToList() );
                }

                return this.products;
            }
        }

        public ObservableCollection<Category> Categories
        {
            get
            {
                if( this.categories == null )
                {
                    this.categories = new ObservableCollection<Category>( this.client.GetCategories().ToList() );
                }

                return this.categories;
            }
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if( this.saveProductCommand == null )
                {
                    this.saveProductCommand = new RelayCommand( p => this.SaveProduct() );
                }

                return this.saveProductCommand;
            }
        }

        private void SaveProduct()
        {
            var product = new Product
            {
                CategoryId = this.Category.Id,
                Description = this.ProductDescription,
                Name = this.ProductName,
                Price = this.ProductPrice,
                Stock = this.ProductStock,
            };

            this.client.CreateProduct( product );
            this.Products.Add( product );
        }
    }
}
