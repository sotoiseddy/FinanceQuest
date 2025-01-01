using FinanceQuest.Lessons;
using FinanceQuest.Services;

namespace FinanceQuest
{
    public partial class MainPage : ContentPage
    {
        private const int XPPerLevel = 100; // Define XP required per level
        private UserProgressService _progressService;

        public MainPage()
        {
            InitializeComponent();

            // Initialize the UserProgressService
            _progressService = new UserProgressService();

            // Display XP and Level dynamically when the page loads
            UpdateProgressDisplay();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Update XP and Level whenever the page appears
            UpdateProgressDisplay();
        }

        private void UpdateProgressDisplay()
        {
            // Fetch updated XP from local storage
            int userXP = Preferences.Default.Get("UserXP", 0);

            // Calculate the user's level based on XP
            int userLevel = (userXP / XPPerLevel) + 1;

            // Update the labels dynamically
            XPLabel.Text = $"Total XP: {userXP}";
            LevelLabel.Text = $"Level: {userLevel}";
        }

        private async void OnStartChapterClicked(object sender, EventArgs e)
        {
            // Navigate to the Lesson1Page
            await Navigation.PushAsync(new Intro());
        }
    }


}
