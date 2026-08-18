using Avalonia.Controls;
using proyecto_de_pruebas.ViewModels;
namespace proyecto_de_pruebas.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click_azul(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (DataContext is MainViewModel vm)
        {
            vm.colorFondo= "Blue";
        }
    }
    private void Button_Click_rojo(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (DataContext is MainViewModel vm)
        {
            vm.colorFondo = "Red";
        }
    }


    private void Button_Click_verde(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (DataContext is MainViewModel vm)
        {
            vm.colorFondo = "Green";
        }
    }
}