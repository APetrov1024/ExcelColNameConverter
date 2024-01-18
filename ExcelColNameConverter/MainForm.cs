namespace ExcelColNameConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const int lettersCount = 26;

        private static int LetterToInt(char letter)
        {
            char _letter = char.ToUpper(letter);
            return _letter - 'A' + 1;
        }

        private static char IntToLetter(int n)
        {
            if (n < 1 || n > lettersCount) throw new ArgumentException();
            return (char)('A' + n - 1);
        }

        private bool preventChangeEvent = false;

        private void LetterStyle_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (preventChangeEvent || LetterStyle_TextBox.Text.Length == 0) return;

            LetterStyle_TextBox.Text = LetterStyle_TextBox.Text.ToUpper().Trim();
            int number = 0;
            int pow = 0;
            for (int i = LetterStyle_TextBox.Text.Length - 1; i >= 0; i--)
            {
                char ch = LetterStyle_TextBox.Text[i];
                if (char.IsLetter(ch))
                {

                    number += LetterToInt(ch) * (int)Math.Pow(lettersCount, pow);
                }
                else
                {
                    continue;
                }
                pow++;
            }
            try
            {
                preventChangeEvent = true;
                NumberStyle_TextBox.Text = number.ToString();
            }
            finally { preventChangeEvent = false; }
        }

        private void NumberStyle_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (preventChangeEvent || NumberStyle_TextBox.Text.Length == 0) return;

            string str = string.Empty;
            int number = Int32.Parse(NumberStyle_TextBox.Text);
            int pow = 0;
            while (number > 0)
            {
                pow++;
                int remainder = number % (int)Math.Pow(lettersCount, pow);
                if (remainder == 0)
                {
                    str = IntToLetter(lettersCount) + str;
                    number -= lettersCount;
                }
                else if (remainder < lettersCount)
                {
                    str = IntToLetter(remainder) + str;
                }
                else if (remainder == lettersCount)
                {
                    str = IntToLetter(1) + str;
                }
                else
                {
                    //var num = remainder - remainder % (int)Math.Pow(lettersCount, pow - 1);
                    var num = remainder / (int)Math.Pow(lettersCount, pow - 1);
                    //num = num < lettersCount ? num : 1;
                    str = IntToLetter(num) + str;
                }
                number -= remainder;
            }
            try
            {
                preventChangeEvent = true;
                LetterStyle_TextBox.Text = str;
            }
            finally { preventChangeEvent = false; }
        }
    }
}