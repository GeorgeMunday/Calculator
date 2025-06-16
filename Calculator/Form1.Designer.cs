namespace Calculator
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
            display = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            number1Button = new Button();
            devideButton = new Button();
            number2Button = new Button();
            number3Button = new Button();
            number4Button = new Button();
            number5Button = new Button();
            number6Button = new Button();
            timesButton = new Button();
            number7Button = new Button();
            number8Button = new Button();
            number9Button = new Button();
            subtractButton = new Button();
            clearButton = new Button();
            number0Button = new Button();
            equalsButton = new Button();
            addButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            display.Location = new Point(12, 58);
            display.Name = "display";
            display.Size = new Size(672, 23);
            display.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(number1Button, 0, 0);
            tableLayoutPanel1.Controls.Add(devideButton, 3, 0);
            tableLayoutPanel1.Controls.Add(number2Button, 1, 0);
            tableLayoutPanel1.Controls.Add(number3Button, 2, 0);
            tableLayoutPanel1.Controls.Add(number4Button, 0, 1);
            tableLayoutPanel1.Controls.Add(number5Button, 1, 1);
            tableLayoutPanel1.Controls.Add(number6Button, 2, 1);
            tableLayoutPanel1.Controls.Add(timesButton, 3, 1);
            tableLayoutPanel1.Controls.Add(number7Button, 0, 2);
            tableLayoutPanel1.Controls.Add(number8Button, 1, 2);
            tableLayoutPanel1.Controls.Add(number9Button, 2, 2);
            tableLayoutPanel1.Controls.Add(subtractButton, 3, 2);
            tableLayoutPanel1.Controls.Add(clearButton, 0, 3);
            tableLayoutPanel1.Controls.Add(number0Button, 1, 3);
            tableLayoutPanel1.Controls.Add(equalsButton, 2, 3);
            tableLayoutPanel1.Controls.Add(addButton, 3, 3);
            tableLayoutPanel1.Location = new Point(12, 145);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(672, 356);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // number1Button
            // 
            number1Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number1Button.Location = new Point(3, 3);
            number1Button.Name = "number1Button";
            number1Button.Size = new Size(162, 83);
            number1Button.TabIndex = 0;
            number1Button.Text = "1";
            number1Button.UseVisualStyleBackColor = true;
            number1Button.Click += number1Button_Click;
            // 
            // devideButton
            // 
            devideButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            devideButton.Location = new Point(507, 3);
            devideButton.Name = "devideButton";
            devideButton.Size = new Size(162, 83);
            devideButton.TabIndex = 1;
            devideButton.Text = "/";
            devideButton.UseVisualStyleBackColor = true;
            devideButton.Click += devideButton_Click;
            // 
            // number2Button
            // 
            number2Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number2Button.Location = new Point(171, 3);
            number2Button.Name = "number2Button";
            number2Button.Size = new Size(162, 83);
            number2Button.TabIndex = 2;
            number2Button.Text = "2";
            number2Button.UseVisualStyleBackColor = true;
            number2Button.Click += number2Button_Click;
            // 
            // number3Button
            // 
            number3Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number3Button.Location = new Point(339, 3);
            number3Button.Name = "number3Button";
            number3Button.Size = new Size(162, 83);
            number3Button.TabIndex = 3;
            number3Button.Text = "3";
            number3Button.UseVisualStyleBackColor = true;
            number3Button.Click += number3Button_Click;
            // 
            // number4Button
            // 
            number4Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number4Button.Location = new Point(3, 92);
            number4Button.Name = "number4Button";
            number4Button.Size = new Size(162, 83);
            number4Button.TabIndex = 4;
            number4Button.Text = "4";
            number4Button.UseVisualStyleBackColor = true;
            number4Button.Click += number4Button_Click;
            // 
            // number5Button
            // 
            number5Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number5Button.Location = new Point(171, 92);
            number5Button.Name = "number5Button";
            number5Button.Size = new Size(162, 83);
            number5Button.TabIndex = 5;
            number5Button.Text = "5";
            number5Button.UseVisualStyleBackColor = true;
            number5Button.Click += number5Button_Click;
            // 
            // number6Button
            // 
            number6Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number6Button.Location = new Point(339, 92);
            number6Button.Name = "number6Button";
            number6Button.Size = new Size(162, 83);
            number6Button.TabIndex = 6;
            number6Button.Text = "6";
            number6Button.UseVisualStyleBackColor = true;
            number6Button.Click += number6Button_Click;
            // 
            // timesButton
            // 
            timesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timesButton.Location = new Point(507, 92);
            timesButton.Name = "timesButton";
            timesButton.Size = new Size(162, 83);
            timesButton.TabIndex = 7;
            timesButton.Text = "*";
            timesButton.UseVisualStyleBackColor = true;
            timesButton.Click += timesButton_Click;
            // 
            // number7Button
            // 
            number7Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number7Button.Location = new Point(3, 181);
            number7Button.Name = "number7Button";
            number7Button.Size = new Size(162, 83);
            number7Button.TabIndex = 8;
            number7Button.Text = "7";
            number7Button.UseVisualStyleBackColor = true;
            number7Button.Click += number7Button_Click;
            // 
            // number8Button
            // 
            number8Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number8Button.Location = new Point(171, 181);
            number8Button.Name = "number8Button";
            number8Button.Size = new Size(162, 83);
            number8Button.TabIndex = 9;
            number8Button.Text = "8";
            number8Button.UseVisualStyleBackColor = true;
            number8Button.Click += number8Button_Click;
            // 
            // number9Button
            // 
            number9Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number9Button.Location = new Point(339, 181);
            number9Button.Name = "number9Button";
            number9Button.Size = new Size(162, 83);
            number9Button.TabIndex = 10;
            number9Button.Text = "9";
            number9Button.UseVisualStyleBackColor = true;
            number9Button.Click += number9Button_Click;
            // 
            // subtractButton
            // 
            subtractButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subtractButton.Location = new Point(507, 181);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(162, 83);
            subtractButton.TabIndex = 11;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearButton.Location = new Point(3, 270);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(162, 83);
            clearButton.TabIndex = 12;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // number0Button
            // 
            number0Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number0Button.Location = new Point(171, 270);
            number0Button.Name = "number0Button";
            number0Button.Size = new Size(162, 83);
            number0Button.TabIndex = 13;
            number0Button.Text = "0";
            number0Button.UseVisualStyleBackColor = true;
            number0Button.Click += number0Button_Click;
            // 
            // equalsButton
            // 
            equalsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equalsButton.Location = new Point(339, 270);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(162, 83);
            equalsButton.TabIndex = 14;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += equalsButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Location = new Point(507, 270);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 83);
            addButton.TabIndex = 15;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 513);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button number1Button;
        private Button devideButton;
        private Button number2Button;
        private Button number3Button;
        private Button number4Button;
        private Button number5Button;
        private Button number6Button;
        private Button timesButton;
        private Button number7Button;
        private Button number8Button;
        private Button number9Button;
        private Button subtractButton;
        private Button clearButton;
        private Button number0Button;
        private Button equalsButton;
        private Button addButton;
    }
}
