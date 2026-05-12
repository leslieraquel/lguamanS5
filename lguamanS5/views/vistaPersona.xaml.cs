using lguamanS5.modelos;

namespace lguamanS5.views;

public partial class vistaPersona : ContentPage
{
	public vistaPersona()
	{
		InitializeComponent();
	}
	
	private void btnAregarPersona(object sender, EventArgs e)	 { 
		lblstatus.Text = "";

		App._personRepo.AddPerson(txtName.Text);
		lblstatus.Text = App._personRepo.status;
	}

    private void btnListar_clicked2(object sender, EventArgs e)
    {
		lblstatus.Text = "holaaa";
		//List<persona> people = App._personRepo.GetPersonList();

  //      lblstatus.Text = $"Total: {people.Count}";
  //      listaPersonas.ItemsSource = people;
    }
   

    private void btnlistarpersona2_Clicked(object sender, EventArgs e)
    {

        List<persona> people = App._personRepo.GetPersonList();

        lblstatus.Text = $"Total: {people.Count}";
        listaPersonas.ItemsSource = people;

    }
}