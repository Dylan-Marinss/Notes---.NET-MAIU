namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "arquivo"); 
        public MainPage()
        {
            InitializeComponent();
            if(File.Exists(caminho))
            TextEditor.Text = File.ReadAllText(caminho); 
        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = TextEditor.Text;
            File.WriteAllText(caminho, conteudo);
            DisplayAlert("Arquivo Salvo", $"Arquivo {caminho} foi salvo com sucesso", "ok");
        }
        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = TextEditor.Text;
            File.Delete(caminho);
            DisplayAlert("Arquivo Apagado", "Arquivo Apagado com sucesso", "Ok");
            TextEditor.Text = string.Empty;
        }

        
    }

}
