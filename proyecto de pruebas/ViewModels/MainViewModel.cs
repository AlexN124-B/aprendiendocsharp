using System.Collections.Generic;
using proyecto_de_pruebas.Models;
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

    public List<Persona> Personas { get; set; } = 
    [
        new Persona("Juan", 20),
        new Persona("María", 25),
        new Persona("Pedro", 20),
        new Persona("Laura", 22)
    ];

}
