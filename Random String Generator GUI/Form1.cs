using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_String_Generator_GUI
{
    public partial class MainMenu : Form
    {
        private const string LETTERS = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMBERS = "0123456789";
        private const string SYMBOLS = "`~!@#$%^&*()_+-={}[]\\|;:\'\",<.>/?";
        private const int LENGTH = 32;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void GenBut_Click(object sender, EventArgs e)
        {
            log($"Generating random string using {LettersTxt.Text}, {NumbersTxt.Text}, {SymbolsTxt.Text} that has uppercase set to {UpperCheck.Checked}, and lowercase set to {LowerCheck.Checked}, with a length of {LengthTxt.Text}.");

            Random rand = new Random();

            if (Int32.Parse(LengthTxt.Text) > 0)
            {
                string localString = "";

                if (NumbersTxt.Text.Length > 0
                    || SymbolsTxt.Text.Length > 0
                    || LettersTxt.Text.Length > 0 && UpperCheck.Checked
                    || LettersTxt.Text.Length > 0 && LowerCheck.Checked)
                {
                    for (int i = 0; i < Int32.Parse(LengthTxt.Text); i++)
                    {
                        int randTemp = rand.Next(0, 4);
                        switch (randTemp)
                        {
                            case 0:
                                if (UpperCheck.Checked && LettersTxt.Text.Length > 0)
                                    localString += LettersTxt.Text[rand.Next(0, LettersTxt.Text.Length)].ToString().ToUpper();
                                else
                                    i--;
                                break;
                            case 1:
                                if (LowerCheck.Checked && LettersTxt.Text.Length > 0)
                                    localString += LettersTxt.Text[rand.Next(0, LettersTxt.Text.Length)].ToString().ToLower();
                                else
                                    i--;
                                break;
                            case 2:
                                if (NumbersTxt.Text.Length > 0)
                                    localString += NumbersTxt.Text[rand.Next(0, NumbersTxt.Text.Length)].ToString().ToLower();
                                else
                                    i--;
                                break;
                            case 3:
                                if (SymbolsTxt.Text.Length > 0)
                                    localString += SymbolsTxt.Text[rand.Next(0, SymbolsTxt.Text.Length)].ToString().ToLower();
                                else
                                    i--;
                                break;
                        }
                    }
                }
                RandomStringTxt.Text = localString;
                log($"String generated: {localString}");
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LettersTxt.Text = LETTERS;
            NumbersTxt.Text = NUMBERS;
            SymbolsTxt.Text = SYMBOLS;
            LengthTxt.Text = LENGTH.ToString();

            RandomStringTxt.Text = "Random String Goes Here";
        }

        private void CopyBut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RandomStringTxt.Text);
            log($"Copied to clipboard: {RandomStringTxt.Text}");
        }

        private void log(string text)
        {
            System.IO.File.AppendAllText(@".\log.txt", $"{DateTime.UtcNow}: {text}\n");
        }
    }
}
