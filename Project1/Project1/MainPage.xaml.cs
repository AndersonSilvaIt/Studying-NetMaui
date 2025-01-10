namespace Project1
{
    public partial class MainPage: ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = $"Contador atual {count}";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
