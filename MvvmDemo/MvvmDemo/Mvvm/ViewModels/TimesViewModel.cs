using MvvmDemo.Mvvm.Models;
namespace MvvmDemo.Mvvm.ViewModels
{
    public class TimesViewModel
    {
        public List<Time> Times { get; set; }

        public TimesViewModel()
        {
            Times = new List<Time>()
            { 
                new Time{ Nome = "Manchester City", Escudo = ""  },
                new Time{ Nome = "Milan", Escudo = ""  },
                new Time{ Nome = "Nápoli", Escudo = ""  },
                new Time{ Nome = "Chelsea", Escudo = ""  },
                new Time{ Nome = "Bayer", Escudo = ""  },
                new Time{ Nome = "Benfica", Escudo = ""  },
                new Time{ Nome = "Real Madrid", Escudo = ""  },
                new Time{ Nome = "PSG", Escudo = ""  },
                new Time{ Nome = "Barcelona", Escudo = "" }
            };
        }
    }
}