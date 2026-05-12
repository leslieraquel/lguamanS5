using lguamanS5.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace lguamanS5
{
    public partial class App : Application
    {

        public static personaRepositorie _personRepo {  get; set; }
        public App(personaRepositorie person)
        {
            InitializeComponent();
            _personRepo = person;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new views.vistaPersona());
        }
    }
}