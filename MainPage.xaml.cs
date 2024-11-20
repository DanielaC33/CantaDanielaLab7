namespace CantaDanielaLab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            // Setează imaginea din codul C#
            // Asigură-te că imaginea este inclusă în proiect ca resursă
            StudentImage.Source = "resource://CantaDanielaLab7.Resources.Images.student_image.png";

            // Setează textul etichetei pentru numele studentului
            StudentName.Text = "Daniela Canta";

            // Setează descrierea studentului
            Description.Text = "Student la Informatica Economică";
        }

        // Metoda care se apelează la click pe buton
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
