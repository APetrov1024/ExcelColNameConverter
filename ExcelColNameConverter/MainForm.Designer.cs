namespace ExcelColNameConverter
{
    partial class MainForm
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
            MainFormTableLayout = new TableLayoutPanel();
            LetterLabel = new Label();
            Number_Label = new Label();
            LetterStyle_TextBox = new TextBox();
            NumberStyle_TextBox = new TextBox();
            MainFormTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainFormTableLayout
            // 
            MainFormTableLayout.AutoSize = true;
            MainFormTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainFormTableLayout.ColumnCount = 2;
            MainFormTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4632759F));
            MainFormTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.53672F));
            MainFormTableLayout.Controls.Add(LetterLabel, 0, 0);
            MainFormTableLayout.Controls.Add(Number_Label, 0, 1);
            MainFormTableLayout.Controls.Add(LetterStyle_TextBox, 1, 0);
            MainFormTableLayout.Controls.Add(NumberStyle_TextBox, 1, 1);
            MainFormTableLayout.Dock = DockStyle.Fill;
            MainFormTableLayout.Location = new Point(0, 0);
            MainFormTableLayout.Name = "MainFormTableLayout";
            MainFormTableLayout.RowCount = 2;
            MainFormTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MainFormTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MainFormTableLayout.Size = new Size(250, 62);
            MainFormTableLayout.TabIndex = 0;
            // 
            // LetterLabel
            // 
            LetterLabel.Anchor = AnchorStyles.Right;
            LetterLabel.AutoSize = true;
            LetterLabel.Location = new Point(18, 8);
            LetterLabel.Name = "LetterLabel";
            LetterLabel.Size = new Size(65, 15);
            LetterLabel.TabIndex = 0;
            LetterLabel.Text = "Letter Style";
            // 
            // Number_Label
            // 
            Number_Label.Anchor = AnchorStyles.Right;
            Number_Label.AutoSize = true;
            Number_Label.Location = new Point(7, 39);
            Number_Label.Name = "Number_Label";
            Number_Label.Size = new Size(76, 15);
            Number_Label.TabIndex = 1;
            Number_Label.Text = "NumberStyle";
            // 
            // LetterStyle_TextBox
            // 
            LetterStyle_TextBox.Dock = DockStyle.Fill;
            LetterStyle_TextBox.Location = new Point(89, 3);
            LetterStyle_TextBox.Name = "LetterStyle_TextBox";
            LetterStyle_TextBox.Size = new Size(158, 23);
            LetterStyle_TextBox.TabIndex = 2;
            LetterStyle_TextBox.TextChanged += LetterStyle_TextBox_TextChanged;
            // 
            // NumberStyle_TextBox
            // 
            NumberStyle_TextBox.Dock = DockStyle.Fill;
            NumberStyle_TextBox.Location = new Point(89, 34);
            NumberStyle_TextBox.Name = "NumberStyle_TextBox";
            NumberStyle_TextBox.Size = new Size(158, 23);
            NumberStyle_TextBox.TabIndex = 3;
            NumberStyle_TextBox.TextChanged += NumberStyle_TextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 62);
            Controls.Add(MainFormTableLayout);
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Column Name Converter";
            MainFormTableLayout.ResumeLayout(false);
            MainFormTableLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel MainFormTableLayout;
        private Label LetterLabel;
        private Label Number_Label;
        private TextBox LetterStyle_TextBox;
        private TextBox NumberStyle_TextBox;
    }
}