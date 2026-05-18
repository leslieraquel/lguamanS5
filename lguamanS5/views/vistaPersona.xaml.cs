using lguamanS5.modelos;

namespace lguamanS5.views;

public partial class vistaPersona : ContentPage
{
	public vistaPersona()
	{

        InitializeComponent();
        CargarPersonas();
	}
	
	private void btnAregarPersona(object sender, EventArgs e)	 { 
		lblstatus.Text = "";

		App._personRepo.AddPerson(txtName.Text);
		lblstatus.Text = App._personRepo.status;
	}
   

    private void btnlistarpersona2_Clicked(object sender, EventArgs e)
    {

        List<persona> people = App._personRepo.GetPersonList();

        lblstatus.Text = $"Total: {people.Count}";
        listaPersonas.ItemsSource = people;

    }
    private void CargarPersonas()
    {

        List<persona> people = App._personRepo.GetPersonList();
        listaPersonas.ItemsSource = people;

    }

    private async void EliminarPersona_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        var persona = button?.CommandParameter as persona;

        if (persona == null)
            return;

        bool respuesta = await DisplayAlert(
            "Confirmación",
            $"¿Eliminar a {persona.Name}?",
            "Sí",
            "No");

        if (respuesta)
        {
            await App._personRepo.DeletePersonaByIdAsync(persona.Id);

            lblstatus.Text = "Persona eliminada correctamente";

            CargarPersonas();
        }
    }


    private async void EditarPersona_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var persona = button?.CommandParameter as persona;

        if (persona == null)
            return;

        await Navigation.PushAsync(new editarPersona(persona, App._personRepo));
    }
}