using temas.Resources.Theme;

namespace temas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool escuro = true;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnTrocar_Clicked(object sender, EventArgs e)
        {
            var mergeDictionaries = Application.Current.Resources.MergedDictionaries; 

            if (mergeDictionaries != null)
            {
                mergeDictionaries.Clear();
                escuro = !escuro;
                if (escuro)
                {
                    mergeDictionaries.Add(new DarkTheme());
                    btnTrocar.Text = "Trocar para Tema Claro";
                }   else
                {
                    mergeDictionaries.Add(new WhiteTheme());
                    btnTrocar.Text = "Trocar para Tema Escuro";
                }
            }
        }
    }

}
