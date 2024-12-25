using static ExpenseCategorizer.ExpenseCategorizerModel;

namespace ExpenseCategorizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            ResultLbl.Text = "Processing...";

            string UserInput = InputTxt.Text;

            if (string.IsNullOrEmpty(UserInput))
            {
                ResultLbl.Text = "Please enter a description.";
                return;
            }

            try
            {
                var input = new ModelInput
                {
                    Col0 = UserInput
                };

                var result = Predict(input);

                ResultLbl.Text = $"Predicted Category: {result.PredictedLabel}";
            }
            catch (Exception ex)
            {
                ResultLbl.Text = ex.Message;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "";
            ResultLbl.Text = "Waiting to run...";
        }
    }
}
