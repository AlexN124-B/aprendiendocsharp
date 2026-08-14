using CommunityToolkit.Mvvm.ComponentModel;

namespace proyecto_de_pruebas.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string rojo { get; set; } = "Rojo";
    [ObservableProperty]
    public partial string azul{ get; set; } = "Azul";

    [ObservableProperty]
    public partial string colorFondo { get; set; } = "white";
}
