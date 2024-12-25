namespace ExpenseCategorizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Description = new Label();
            InputTxt = new TextBox();
            RunBtn = new Button();
            ClearBtn = new Button();
            ResultLbl = new Label();
            Title = new Label();
            SuspendLayout();
            // 
            // Description
            // 
            Description.Font = new Font("Times New Roman", 12F);
            Description.Location = new Point(73, 131);
            Description.Name = "Description";
            Description.Size = new Size(857, 41);
            Description.TabIndex = 1;
            Description.Text = "Please type in an expense and the program will categorize what type of expense it is";
            // 
            // InputTxt
            // 
            InputTxt.Location = new Point(73, 191);
            InputTxt.Name = "InputTxt";
            InputTxt.PlaceholderText = "Expense, eg. Water bill";
            InputTxt.Size = new Size(500, 31);
            InputTxt.TabIndex = 2;
            // 
            // RunBtn
            // 
            RunBtn.Location = new Point(597, 188);
            RunBtn.Name = "RunBtn";
            RunBtn.Size = new Size(106, 36);
            RunBtn.TabIndex = 3;
            RunBtn.Text = "Run";
            RunBtn.UseVisualStyleBackColor = true;
            RunBtn.Click += RunBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(732, 188);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(106, 36);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ResultLbl
            // 
            ResultLbl.Font = new Font("Times New Roman", 12F);
            ResultLbl.Location = new Point(99, 300);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(654, 131);
            ResultLbl.TabIndex = 5;
            ResultLbl.Text = "Waiting to run...";
            // 
            // Title
            // 
            Title.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(73, 34);
            Title.Name = "Title";
            Title.Size = new Size(827, 85);
            Title.TabIndex = 6;
            Title.Text = "Expense Categorizer";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1020, 557);
            Controls.Add(Title);
            Controls.Add(ResultLbl);
            Controls.Add(ClearBtn);
            Controls.Add(RunBtn);
            Controls.Add(InputTxt);
            Controls.Add(Description);
            Name = "Form1";
            Text = "Expense Categorizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Description;
        private TextBox InputTxt;
        private Button RunBtn;
        private Button ClearBtn;
        private Label ResultLbl;
        private Label Title;
    }
}
