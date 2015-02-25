using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WordDescramble.Properties;


namespace WordDescramble
{
    public partial class DescramblerForm : Form
    {
        public DescramblerForm()
        {
            InitializeComponent();
        }
        public string FileNameMinusPath { get; set; }
        public string FullFilePath { get; set; }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            bool correctFileType = false;
            while (!correctFileType)
            {
                DialogResult dialogUserReponse = OpenFileDialog.ShowDialog();
                if (dialogUserReponse == DialogResult.OK)
                {
                   FullFilePath = OpenFileDialog.FileName;
                   string documentPath = FullFilePath;
                   FileNameMinusPath = Path.GetFileName(documentPath);
                   string documentExtension = Path.GetExtension(documentPath);
                   if (documentExtension.Equals(".txt"))
                   {
                       TestFileInput.Text = documentPath;
                       correctFileType = true;
                   }
                   else
                   {
                       MessageBox.Show(this, Resources.IncorrectImportMessage);
                   }
                }
                else if (dialogUserReponse == DialogResult.Cancel)
                {
                    break;
                }
            }
            
        }


        private void goButton_Click(object sender, EventArgs e)
        {

            using (StreamReader fileText = new StreamReader(FullFilePath))
            {

                string[] testStrings =  fileText.ReadToEnd().Split(new string[]{Environment.NewLine },StringSplitOptions.RemoveEmptyEntries);
                
                var testStringsToLower = new string [testStrings.Length];
                for (var i = 0; i < testStrings.Length; i++)
                {
                    testStrings[i] = testStrings[i].Trim();
                    testStringsToLower[i] = testStrings[i].ToLower();
                }
                var scrambledWordListArray = ScrambledListTextbox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                for (var i = 0; i < scrambledWordListArray.Length; i++)
                {
                    scrambledWordListArray[i] = scrambledWordListArray[i].Trim();
                    scrambledWordListArray[i] = scrambledWordListArray[i].ToLower();
                }
                string descrambledList = "";
                for (var word=0; word<scrambledWordListArray.Length; word++)
                {
                    string scrambledWord = scrambledWordListArray[word];
                    var scrambledWordArray = scrambledWord.ToArray();
                    for (var i = 0; i < testStringsToLower.Length; i++)
                    {
                        var unscrambledWordListCharArray = testStringsToLower[i].ToCharArray();
                        int evaluationInteger = 0;
                        if(scrambledWordArray.Length != unscrambledWordListCharArray.Length)
                        {
                            continue;
                        }
                        else
                        {
                            for (var scrambledWordLetterPosition = 0; scrambledWordLetterPosition < scrambledWordArray.Length; scrambledWordLetterPosition++)
                            {
                                for (var unscrambledWordLetterPosition = 0; unscrambledWordLetterPosition < unscrambledWordListCharArray.Length; unscrambledWordLetterPosition++)
                                {
                                    if (scrambledWordArray[scrambledWordLetterPosition] == unscrambledWordListCharArray[unscrambledWordLetterPosition])
                                    {
                                        int removedLetterCounter = Array.IndexOf(unscrambledWordListCharArray, unscrambledWordListCharArray[unscrambledWordLetterPosition]);
                                        unscrambledWordListCharArray = unscrambledWordListCharArray.Where((val, idx) => idx != removedLetterCounter).ToArray();
                                        evaluationInteger++;
                                        if (unscrambledWordLetterPosition > 0)
                                        {
                                            unscrambledWordLetterPosition--;
                                        }
                                    }
                                }
                                if (scrambledWordLetterPosition == 0 && evaluationInteger < 1)
                                {
                                    break;
                                }
                            }
                            if(evaluationInteger.Equals(testStrings[i].Length))
                            {
                                if (word < scrambledWordListArray.Length-1)
                                {
                                    descrambledList = descrambledList + testStrings[i] + ",";
                                    break;
                                }
                                else
                                {
                                    descrambledList = descrambledList + testStrings[i];
                                    break;
                                }
                            }
                        }
                    }

                }

                ScrambledListTextbox.Text = descrambledList;

            }
        }

        

        private void ScrambledList_Leave(object sender, EventArgs e)
        {
            if (TestFileInput.Text != "" && ScrambledListTextbox.Text != "")
            {
                GoButton.Enabled = true;
            }
        }


 
    }
}
