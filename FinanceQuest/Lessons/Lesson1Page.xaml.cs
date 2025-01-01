namespace FinanceQuest.Lessons;

public partial class Lesson1Page : ContentPage
{
    private Label dynamicLabel;
    private Label dynamicLabel2;
    private Button button1, button2, button3, button4;
    private BoxView shrinkingCircle;
    private int currentQuestionIndex = 0;
    private List<FinanceQuestion> questions;
    private int userXP = 0;  // Declare the userXP variable here

    public Lesson1Page()
    {
        this.BackgroundColor = Color.FromHex("#500073");
        // Initialize questions with varied answers
        userXP = Preferences.Default.Get("UserXP", 0);
        questions = new List<FinanceQuestion>
        {
            new FinanceQuestion
            {
                QuestionText = "What is 10% of 100?",
                Answers = new List<string> { "5", "10", "15", "20" },
                CorrectAnswerIndex = 1 // Correct answer is 10
            },
            new FinanceQuestion
            {
                QuestionText = "What is the formula for compound interest?",
                Answers = new List<string> { "A = P(1 + r/n)^(nt)", "A = P + r*t", "A = P(1 + rt)", "A = P * r * t" },
                CorrectAnswerIndex = 0 // Correct answer is A = P(1 + r/n)^(nt)
            },
            new FinanceQuestion
            {
                QuestionText = "What does APR stand for?",
                Answers = new List<string> { "Annual Payment Rate", "Annual Percentage Rate", "Accumulated Payment Rate", "Annual Profit Rate" },
                CorrectAnswerIndex = 1 // Correct answer is Annual Percentage Rate
            },
            new FinanceQuestion
            {
                QuestionText = "What is a budget?",
                Answers = new List<string> { "A tool for reducing expenses", "A statement of bank balance", "A plan for money", "A plan for income" },
                CorrectAnswerIndex = 2 // Correct answer is A plan for money
            },
            new FinanceQuestion
            {
                QuestionText = "What is an emergency fund?",
                Answers = new List<string> { "Money for vacation", "Money for emergencies", "Money for shopping", "Money for investments" },
                CorrectAnswerIndex = 1 // Correct answer is Money for emergencies
            },
            new FinanceQuestion
            {
                QuestionText = "Which is a fixed expense?",
                Answers = new List<string> { "Entertainment", "Utility bills", "Groceries", "Rent" },
                CorrectAnswerIndex = 3 // Correct answer is Rent
            },
            new FinanceQuestion
            {
                QuestionText = "What is credit?",
                Answers = new List<string> { "Money you save", "Money you borrow", "Money you invest", "Money you donate" },
                CorrectAnswerIndex = 1 // Correct answer is Money you borrow
            },
            new FinanceQuestion
            {
                QuestionText = "What is compound interest?",
                Answers = new List<string> { "Interest on principal only", "Interest that never changes", "Interest paid monthly", "Interest on interest" },
                CorrectAnswerIndex = 3 // Correct answer is Interest on interest
            },
            new FinanceQuestion
            {
                QuestionText = "What is a 401(k)?",
                Answers = new List<string> { "Retirement savings account", "Insurance policy", "Investment account", "Bank loan" },
                CorrectAnswerIndex = 0 // Correct answer is Retirement savings account
            },
            new FinanceQuestion
            {
                QuestionText = "What is a stock?",
                Answers = new List<string> { "A type of savings", "Ownership in a company", "A type of loan", "A kind of bond" },
                CorrectAnswerIndex = 1 // Correct answer is Ownership in a company
            },
            new FinanceQuestion
            {
                QuestionText = "What is the purpose of investing?",
                Answers = new List<string> { "To spend money", "To avoid taxes", "To grow wealth", "To build debt" },
                CorrectAnswerIndex = 2 // Correct answer is To grow wealth
            },
            new FinanceQuestion
            {
                QuestionText = "What is diversification?",
                Answers = new List<string> { "Investing in one stock", "Spreading investments", "Consolidating investments", "Saving all cash in a bank" },
                CorrectAnswerIndex = 1 // Correct answer is Spreading investments
            },
            new FinanceQuestion
            {
                QuestionText = "What is a bond?",
                Answers = new List<string> { "A type of savings account", "A type of loan", "A debt investment", "A bank account" },
                CorrectAnswerIndex = 2 // Correct answer is A debt investment
            },
            new FinanceQuestion
            {
                QuestionText = "What does the term 'assets' refer to?",
                Answers = new List<string> { "Things you owe", "Things you own", "Money you borrow", "Money you spend" },
                CorrectAnswerIndex = 1 // Correct answer is Things you own
            },
            new FinanceQuestion
            {
                QuestionText = "What is a credit score?",
                Answers = new List<string> { "A type of bank account", "A loan amount", "A measure of creditworthiness", "A savings rate" },
                CorrectAnswerIndex = 2 // Correct answer is A measure of creditworthiness
            },
            new FinanceQuestion
            {
                QuestionText = "What is a checking account used for?",
                Answers = new List<string> { "Daily transactions", "Long-term savings", "Loans", "Investments" },
                CorrectAnswerIndex = 0 // Correct answer is Daily transactions
            },
            new FinanceQuestion
            {
                QuestionText = "What is passive income?",
                Answers = new List<string> { "Income from a job", "Income from a loan", "Income earned with little effort", "Income from sales" },
                CorrectAnswerIndex = 2 // Correct answer is Income earned with little effort
            },
            new FinanceQuestion
            {
                QuestionText = "What is a savings account?",
                Answers = new List<string> { "A type of investment", "A savings plan", "A place to save money", "A credit card" },
                CorrectAnswerIndex = 2 // Correct answer is A place to save money
            },
            new FinanceQuestion
            {
                QuestionText = "What is inflation?",
                Answers = new List<string> { "A type of loan", "Increase in prices", "A decrease in savings", "A decrease in income" },
                CorrectAnswerIndex = 1 // Correct answer is Increase in prices
            },
            new FinanceQuestion
            {
                QuestionText = "What is an income statement?",
                Answers = new List<string> { "A loan repayment schedule", "A report of earnings and expenses", "A credit score report", "A report of assets" },
                CorrectAnswerIndex = 1 // Correct answer is A report of earnings and expenses
            },
            new FinanceQuestion
            {
                QuestionText = "What is a financial goal?",
                Answers = new List<string> { "A target for saving or investing", "A loan plan", "A spending strategy", "A budget category" },
                CorrectAnswerIndex = 0 // Correct answer is A target for saving or investing
            },
            new FinanceQuestion
            {
                QuestionText = "What is a tax deduction?",
                Answers = new List<string> { "A reduction in taxable income", "An increase in income", "An increase in savings", "A decrease in expenses" },
                CorrectAnswerIndex = 0 // Correct answer is A reduction in taxable income
            },
            new FinanceQuestion
            {
                QuestionText = "What is a mutual fund?",
                Answers = new List<string> { "A savings account", "A pool of funds for investments", "A type of insurance", "A form of loan" },
                CorrectAnswerIndex = 1 // Correct answer is A pool of funds for investments
            },
            new FinanceQuestion
            {
                QuestionText = "What is a loan interest?",
                Answers = new List<string> { "A cost of borrowing money", "The amount of money borrowed", "A repayment amount", "The monthly payment" },
                CorrectAnswerIndex = 0 // Correct answer is A cost of borrowing money
            },
            new FinanceQuestion
            {
                QuestionText = "What is a financial planner?",
                Answers = new List<string> { "A person who helps with money management", "A loan officer", "A bank account manager", "A financial advisor" },
                CorrectAnswerIndex = 0 // Correct answer is A person who helps with money management
            }
        };

        StackLayout stackLayout = new StackLayout
        {
            Spacing = 10,
            Padding = 20
        };

        dynamicLabel = new Label
        {
            Text = questions[currentQuestionIndex].QuestionText,
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center
        };
        dynamicLabel2 = new Label
        {
            Text = "",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center
        };
        shrinkingCircle = new BoxView
        {
            Color = Colors.DarkRed,
            WidthRequest = 150,
            HeightRequest = 150,
            CornerRadius = 75,
            HorizontalOptions = LayoutOptions.Center
        };
        Label circleText = new Label
        {
            Text = " ",  // Change to desired text
            FontSize = 40,
            TextColor = Colors.White,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        AbsoluteLayout absoluteLayout = new AbsoluteLayout
        {
            WidthRequest = 150,
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        absoluteLayout.Children.Add(shrinkingCircle);
        absoluteLayout.Children.Add(circleText);

        stackLayout.Children.Add(absoluteLayout);
        stackLayout.Children.Add(dynamicLabel);
        stackLayout.Children.Add(dynamicLabel2);
        button1 = CreateAnswerButton(0);
        button2 = CreateAnswerButton(1);
        button3 = CreateAnswerButton(2);
        button4 = CreateAnswerButton(3);

        stackLayout.Children.Add(button1);
        stackLayout.Children.Add(button2);
        stackLayout.Children.Add(button3);
        stackLayout.Children.Add(button4);

        Content = stackLayout;
    }

    private Button CreateAnswerButton(int answerIndex)
    {
        Button button = new Button
        {
            Text = questions[currentQuestionIndex].Answers[answerIndex],
            HorizontalOptions = LayoutOptions.Center,
            BackgroundColor = Color.FromHex("#C62300"),  // Set background color to the third color
            TextColor = Colors.White,  // Optional: Set text color to white for better contrast
            HeightRequest = 50,  // Optional: Adjust button height
            CornerRadius = 10,  // Optional: Rounded corners for the button
            Padding = new Thickness(10)  // Optional: Add some padding for a better look
        };

        button.Clicked += (sender, args) =>
        {
            if (answerIndex == questions[currentQuestionIndex].CorrectAnswerIndex)
            {
                currentQuestionIndex++;
                if (currentQuestionIndex < questions.Count)
                {
                    UpdateQuestion();
                    ShrinkCircle();
                    dynamicLabel2.Text = "";
                }
                else
                {
                    dynamicLabel.Text = "Congratulations! You've killed  the circle";
                    HideCircle();
                    button1.IsVisible = button2.IsVisible = button3.IsVisible = button4.IsVisible = false;
                    IncreaseXP();
                }
            }
            else
            {
                dynamicLabel2.Text = "Incorrect! Try again.";
            }
        };

        return button;
    }

    private void UpdateQuestion()
    {
        dynamicLabel.Text = questions[currentQuestionIndex].QuestionText;

        button1.Text = questions[currentQuestionIndex].Answers[0];
        button2.Text = questions[currentQuestionIndex].Answers[1];
        button3.Text = questions[currentQuestionIndex].Answers[2];
        button4.Text = questions[currentQuestionIndex].Answers[3];
    }
    private void ShrinkCircle()
    {
        // Calculate the proportion of questions remaining
        double remainingProportion = (double)(questions.Count - currentQuestionIndex) / questions.Count;

        // Set a new size for the circle based on the remaining proportion
        double newSize = Math.Max(50, 150 * remainingProportion); // Minimum size is 50
        shrinkingCircle.WidthRequest = newSize;
        shrinkingCircle.HeightRequest = newSize;
        shrinkingCircle.CornerRadius = (float)(newSize / 2); // Keep the circle shape
    }
    private void HideCircle()
    {
        shrinkingCircle.IsVisible = false;
    }
    private void IncreaseXP()
    {
        userXP += 10;  // Increase by 10 points (adjust as needed)
        Preferences.Default.Set("UserXP", userXP);
        dynamicLabel.Text = $"Correct! You've earned 10 XP. Total XP: {userXP}";
    }
}



public class FinanceQuestion
{
    public string QuestionText { get; set; }
    public List<string> Answers { get; set; }
    public int CorrectAnswerIndex { get; set; }
}
