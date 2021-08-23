using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CST150W3A5 {
    public partial class Form1 : Form {
        private static readonly char[] Vowels = "aeiou".ToCharArray();
        private string _contents;
        public Form1() {
            InitializeComponent();
            outputTxt.ReadOnly = true;
        }

        private static string MostVowels(IEnumerable< string > array) {
            int mostVowels = 0;
            int i;
            string word = "";
            foreach (string s in array) {
                i = s.Count(c => Vowels.Any(x => x == c));
                if (i <= mostVowels) continue;
                mostVowels = i;
                word = s;
            }
            return word;
        }


        private static string LongestWord(IReadOnlyList< string > array) {
            string longest = array[0];
            foreach (string t in array) {
                if (t.Length > longest.Length)
                    longest = t;
            }

            return longest;
        }

        private bool OpenFile() {
            OpenFileDialog ofd = new() {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };


            if (ofd.ShowDialog() == DialogResult.OK) {
                _contents = File.ReadAllText(ofd.FileName);
            }

            if (_contents == null) {
                throw new NullReferenceException("Must select ");
            }
            // Contents loaded
            return true;
        }

        private void DisplayAndWriteOutput() {
            // To Lower
            string lower = _contents.ToLower();
            string[] array = lower.Split();
            // First and last word
            ( string first, string last ) = ( array.First(), array.Last() );
            string longestWord = LongestWord(array);
            string mostVowels = MostVowels(array);
            var sb = new StringBuilder();
            sb.AppendLine($"First word: {first}");
            sb.AppendLine($"Last word: {last}");
            sb.AppendLine($"Longest word: {longestWord}");
            sb.AppendLine($"Word with most vowels: {mostVowels}");
            sb.AppendLine($"\n\nContent: {_contents}");
            outputTxt.Text = sb.ToString();
            File.WriteAllText("output.txt", sb.ToString());
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!OpenFile())
            {
                MessageBox.Show(this, "Cannot open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1);
                return;
            }

            DisplayAndWriteOutput();
        }
    }
}

/*
    * 1. Converts all the words to lower-case.
    * 2. Finds the first and last word alphabetically.
    * 3. Finds the longest word.
    * 4. Finds the word with the most vowels.
    *    Display the above statistics in a text box and write the above statistics to a file; include a screenshot of your program running with successful output.
 */