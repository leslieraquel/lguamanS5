using lguamanS5.modelos;
using lguamanS5.Repositories;

namespace lguamanS5.views;

public partial class editarPersona : ContentPage
{
        private persona _persona;
        private personaRepositorie _db;
	public editarPersona(persona persona, personaRepositorie db)
	{
		InitializeComponent();

        _persona = persona;
        _db = db;

        txtNombre.Text = persona.Name;
    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        _persona.Name = txtNombre.Text;

        await _db.UpdateAsync(_persona);

        await DisplayAlert("OK", "Persona actualizada", "Aceptar");

        await Navigation.PushAsync(new vistaPersona());
    }
}