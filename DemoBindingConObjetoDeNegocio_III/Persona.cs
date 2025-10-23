using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBindingConObjetoDeNegocio_III
{
    // Crear una clase de negocio que implemente INotifyPropertyChanged mediante "ObservableObject",
    // de modo que notifique a la UI cuando una propiedad cambie.

    // En este caso la clase "Persona" es parcial, por el atributo [ObservableProperty] para cada campo
    // privado, que genera automáticamente las propiedades públicas con notificación de cambios.
    public partial class Persona : ObservableObject
    {
        // public string Nombre { get; set; }
        
        [ObservableProperty]
        private string nombre;

        //private string? _nombre;
        //public string? Nombre
        //{
        // Segunda versión usando SetProperty

        //    get { return _nombre; }
        //    set => SetProperty(ref _nombre, value);

        // Primera versión sin usar SetProperty
        //set
        //    //{
        //    //    if (_nombre != value)
        //    //    {
        //    //        _nombre = value;
        //    //        NotifyPropertyChanged("Nombre"); // Notificar el cambio de propiedad
        //    //    }
        //    //}
        //}

        // public int Edad { get; set; }

        [ObservableProperty]
        private int edad;

        //private int _edad;
        //public int Edad
        //{
        // Segunda versión usando SetProperty
        //    get { return _edad; }
        //    set => SetProperty(ref _edad, value);

        // Primera versión sin usar SetProperty
              //set
        //    //{
        //    //    if (_edad != value)
        //    //    {
        //    //        _edad = value;
        //    //        NotifyPropertyChanged("Edad"); // Notificar el cambio de propiedad
        //    //    }
        //    //}
        //}

        // Constructor vacío y con parámetros
        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Implementación de INotifyPropertyChanged
        // 
        // public event PropertyChangedEventHandler? PropertyChanged;
        // public void NotifyPropertyChanged(string propertyName)
        // {
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        // }
    }
}
