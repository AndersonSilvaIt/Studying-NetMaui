using System.Collections.ObjectModel;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get
            {
                return fotos;
            }
            set
            {
                fotos = value;
            }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto { Nome = "Andrônema", ImagemUrl = "galaxia1.jpg "},
                new Foto { Nome = "Via Láctea", ImagemUrl = "galaxia2.jpg "},
                new Foto { Nome = "Universo", ImagemUrl = "galaxia3.jpg "},
                new Foto { Nome = "Galáxia", ImagemUrl = "galaxia4.jpg "},
                new Foto { Nome = "Sombrero", ImagemUrl = "galaxia5.jpg "},

                new Foto { Nome = "Andrônema 1111", ImagemUrl = "galaxia1.jpg "},
                new Foto { Nome = "Via Láctea 1111", ImagemUrl = "galaxia2.jpg "},
                new Foto { Nome = "Universo 1111", ImagemUrl = "galaxia3.jpg "},
                new Foto { Nome = "Galáxia 1111", ImagemUrl = "galaxia4.jpg "},
                new Foto { Nome = "Sombrero 1111", ImagemUrl = "galaxia5.jpg "},

                new Foto { Nome = "Andrônema 2222", ImagemUrl = "galaxia1.jpg "},
                new Foto { Nome = "Via Láctea 2222", ImagemUrl = "galaxia2.jpg "},
                new Foto { Nome = "Universo 2222", ImagemUrl = "galaxia3.jpg "},
                new Foto { Nome = "Galáxia 2222", ImagemUrl = "galaxia4.jpg "},
                new Foto { Nome = "Sombrero 2222", ImagemUrl = "galaxia5.jpg "},

                new Foto { Nome = "Andrônema 3333", ImagemUrl = "galaxia1.jpg "},
                new Foto { Nome = "Via Láctea 3333", ImagemUrl = "galaxia2.jpg "},
                new Foto { Nome = "Universo 3333", ImagemUrl = "galaxia3.jpg "},
                new Foto { Nome = "Galáxia 3333", ImagemUrl = "galaxia4.jpg "},
                new Foto { Nome = "Sombrero 3333", ImagemUrl = "galaxia5.jpg "},
            };
        }
    }
}