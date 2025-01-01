namespace FinanceQuest.Lessons;

public partial class Intro : ContentPage
{
    private BoxView blueCircle;
    private Label messageLabel;
    private Button nextButton;
    private int messageIndex = 0;

    // Messages for the dynamic label
    private readonly List<string> messages = new List<string>
    {
       "Greetings, traveler! You stand before the noble Blue Army. Will you pledge your loyalty and join our cause?",
       "Together, we forge an unbreakable alliance of strength, wisdom, and unity, bound by the power of our shared purpose!",
       "With the power of ancient knowledge and the mastery of finance, we shall vanquish the Red Horde and restore balance to the realm!",
       "The Blue Army thrives on the courage and intellect of its champions. Are you ready to rise and lead us to victory?"

    };
    public Intro()
    {
        InitializeComponent();
        this.BackgroundColor = Color.FromHex("#500073");

        // Blue circle definition
        blueCircle = new BoxView
        {
            Color = Color.FromHex("#00296B"),
            WidthRequest = 150,
            HeightRequest = 150,
            CornerRadius = 75,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        // Label below the circle
        messageLabel = new Label
        {
            Text = messages[messageIndex],
            FontSize = 18,
            TextColor = Color.FromHex("#FFFFFF"), // White text for contrast
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Margin = new Thickness(20)
        };

        // "Next" button
        nextButton = new Button
        {
            Text = "Next",
            BackgroundColor = Color.FromHex("#C62300"), // Deep red
            TextColor = Color.FromHex("#FFFFFF"),       // White text
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        nextButton.Clicked += OnNextButtonClicked;

        // Layout for the page
        StackLayout stackLayout = new StackLayout
        {
            Spacing = 20,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Children = { blueCircle, messageLabel, nextButton }
        };

        Content = stackLayout;
    }

    private void OnNextButtonClicked(object sender, EventArgs e)
    {
        // Increment message index
        messageIndex++;

        if (messageIndex < messages.Count)
        {
            // Update the label text dynamically
            messageLabel.Text = messages[messageIndex];
        }
        else
        {
            // Navigate to Lesson1Page after the last message
            Navigation.PushAsync(new Lesson1Page());
        }
    }
}