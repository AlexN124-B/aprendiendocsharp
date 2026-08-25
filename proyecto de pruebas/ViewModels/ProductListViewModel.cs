using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using proyecto_de_pruebas.Models;
using proyecto_de_pruebas.Services;

namespace proyecto_de_pruebas.ViewModels
{
    public partial class ProductListViewModel : ViewModelBase
    {
        private readonly ProductApiService _apiService;

        [ObservableProperty]
        private ObservableCollection<Product> _products = new();

        [ObservableProperty]
        private bool _isLoading;

        public ProductListViewModel()
        {
            _apiService = new ProductApiService();
        }

        [RelayCommand]
        private async Task LoadProductsAsync()
        {
            IsLoading = true;

            var result = await _apiService.GetProductsAsync();

            Products = new ObservableCollection<Product>(result);

            IsLoading = false;
        }
    }
}