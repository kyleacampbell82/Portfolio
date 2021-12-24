using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

/******************
 * Kyle Campbell
 * ITD 1253-60438
 * 12 Dec 2021
 ******************/

namespace Section3WeeksProject
{
    public partial class StringStats : Form
    {
        public StringStats()
        {
            InitializeComponent();
        }

        /* Error list made class level to be passed back and forth 
        * between Validator, click events, and primary method */
        List<string> errorList = new List<string>();
        string errorOutput = "";

        /* Class Scope Lists Created to facilitate
        * A Decision Tree Based On UI Elements */

        // Word Lists
        List<string> wordList = new List<string>();
        List<string> uniqueWordList = new List<string>();
        List<string> uniqueWordFreqList = new List<string>();

        // Word-Pair Lists
        List<string> pairList = new List<string>();
        List<string> uniquePairList = new List<string>();
        List<string> uniquePairFreqList = new List<string>();
        List<string> finalList = new List<string>();
        string outputListStr = "";

        // Stats Lists
        List<string> wordStats = new List<string>();
        List<string> uniqueWordStats = new List<string>();
        List<string> pairStats = new List<string>();
        List<string> uniquePairStats = new List<string>();
        List<string> finalStats = new List<string>();
        string outputStatsStr = "";

        /* Class Scope Variables Created to 
         * facilitate an Update Method 
         * for Radio Buttons and Check Boxes */
        int charCount = 0;
        int sentenceCount = 0;
        int wordCount = 0;
        int uniqueCount = 0;
        decimal avgWordLength = 0;
        decimal avgUniqueWordLength = 0;
        decimal avgWordPairLength = 0;
        int wordPairCount = 0;
        int totalWordPairLength = 0;
        int uniquePairCount = 0;
        int totalUniquePairLength = 0;
        decimal avgUniquePairLength = 0;
        string validatedStr = "";
        
        // List Click Event Handler
        private void btn_ShowList_Click(object sender, EventArgs e)
        {
            validatedStr = Validator(box_Input.Text);

            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                UpdateOutput();
                ListOutputSelector();
            }
        }

        // Stats Click Event Handler
        private void btn_Stats_Click(object sender, EventArgs e)
        {
            validatedStr = Validator(box_Input.Text);

            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                UpdateOutput();
                StatsOutputSelector();
            }
        }

        // Validates input and changes all letters to lowercase
        public string Validator(string userInput)
        {
            string validInput = "";
            try
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    Error(1);
                }
                else
                {
                    validInput = userInput.ToLower();
                }
            }
            catch (OverflowException)
            {
                Error(1);
            }
            catch (FormatException)
            {
                Error(2);
            }
            return validInput;
        }

        // Scrubs Punctuation excluding hypens and apostrophies.
        public string RemovePuncandCaps(string inputStr)
        {
            string remPuncAndCapsStr = new string(inputStr.Where(c => (!char.IsPunctuation(c)) || (c == '-') || (c == 39)).ToArray());
            return remPuncAndCapsStr;
        }

        public void Words(string inputStr)
        {
            // Characters
            char[] characters = new char[inputStr.Length];
            for (int i = 0; i < inputStr.Length; i++)
            {
                charCount++;
            }
            string outputCharCount = $"{"Total Characters: "}{charCount}";

            // Sentences
            foreach (char c in inputStr)
            {
                if ((c == '.') || (c == '!') || (c == '?'))
                {
                    sentenceCount++;
                }
            }
            string outputSentenceCount = $"{"Total Sentences: "}{sentenceCount}";

            // Remove Punc for Words
            string newInputStr = RemovePuncandCaps(inputStr);

            string[] words = newInputStr.Split(' ');

            string[] wordArr = words.ToArray();
            string[] word_distinct = wordArr.Distinct().ToArray();

            // Words
            foreach (var word in words)
            {
                wordList.Add(word);
            }

            int totalWordLength = 0;
            foreach (var word in words)
            {
                totalWordLength = totalWordLength + word.Length;
                wordCount++;
            }
            avgWordLength = totalWordLength / wordCount;
            string outputWordCount = $"{"Total Words: "}{wordCount}";
            string avgWordLengthStr = $"{"Average Word Length: "}{avgWordLength}";

            // Unique Words
            int totalUniqueWordLength = 0;

            foreach (var word in word_distinct)
            {
                uniqueCount = (from x1 in wordArr where x1.ToString() == word select x1).Count();
                if (uniqueCount > 1)
                {
                    string uniqueStr = $"{word}";
                    uniqueWordList.Add(uniqueStr);

                    totalUniqueWordLength = totalUniqueWordLength + word.Length;

                    string uniqueFreqStr = $"{uniqueCount}{" : "}{word}";
                    uniqueWordFreqList.Add(uniqueFreqStr);
                }              
            }
            avgUniqueWordLength = totalUniqueWordLength / uniqueCount;
            string outputUniqueWordCount = $"{"Total Unique Words: "}{uniqueCount}";
            string avgUniqueWordLengthStr = $"{"Average Unique Word Length: "}{avgUniqueWordLength}";


            // Adding Universal Stats to All Lists
            wordStats.Add(outputCharCount);
            wordStats.Add(outputSentenceCount);
            uniqueWordStats.Add(outputCharCount);
            uniqueWordStats.Add(outputSentenceCount);
            pairStats.Add(outputCharCount);
            pairStats.Add(outputSentenceCount);
            uniquePairStats.Add(outputCharCount);
            uniquePairStats.Add(outputSentenceCount);

            // Adding Word Stats to List
            wordStats.Add(outputWordCount);
            wordStats.Add(avgWordLengthStr);

            // Adding Unique Word Stats to List
            uniqueWordStats.Add(outputUniqueWordCount);
            uniqueWordStats.Add(avgUniqueWordLengthStr);
        }

        public void Pairs(string inputStr)
        {
            List<string> newPairList = new List<string>();
            string[] wordPairs = inputStr.Split();
            string wordPairStr = "";  

            // Regular Pairs
            for (int i = 1; i < wordPairs.Length; i++)
            {
                wordPairStr = $"{wordPairs[i - 1]}{" : "}{wordPairs[i]}";
                wordPairCount++;
                totalWordPairLength = totalWordPairLength + wordPairs.Length;

                newPairList.Add(wordPairStr);
                pairList.Add(wordPairStr);
            }
            if (wordPairCount == 0)
            {
                avgWordPairLength = 0;
            }
            else
            {
                avgWordPairLength = totalWordPairLength / wordPairCount;
            }
            string pairCountStr = $"{"Total Word-Pairs: "}{wordPairCount}";
            string wordPairAvgLenghtStr = $"{"Average Word-Pair Length: "}{avgWordPairLength}";

            // Adding Word-Pair Stats to List
            pairStats.Add(pairCountStr);
            pairStats.Add(wordPairAvgLenghtStr);

            //Unique Pairs
            string[] wordArr = newPairList.ToArray();
            string[] wordPairs_distinct = wordArr.Distinct().ToArray();

            foreach (var wordPair in wordPairs_distinct)
            {
                uniquePairCount = (from x1 in wordArr where x1.ToString() == wordPair select x1).Count();
                if (uniquePairCount > 1)
                {
                    string uniqueStr = $"{wordPair}";
                    uniquePairList.Add(uniqueStr);
                    totalWordPairLength = totalWordPairLength + wordPair.Length;

                    string uniqueFreqStr = $"{uniquePairCount}{" : "}{wordPair}";
                    uniquePairFreqList.Add(uniqueFreqStr);
                }
            }
            if (uniquePairCount == 0)
            {
                avgUniquePairLength = 0;
            }
            else
            {
                avgUniquePairLength = totalUniquePairLength / uniquePairCount;
            }
            string uniquePairCountStr = $"{"Total Unique Word-Pairs: "}{uniquePairCount}";
            string uniquePairAvgLenghtStr = $"{"Average Unique Word-Pair Length: "}{avgUniquePairLength}";

            // Adding Unique Word-Pair Stats to List
            uniquePairStats.Add(uniquePairCountStr);
            uniquePairStats.Add(uniquePairAvgLenghtStr);
        }

        // Output Methods
        public void StatsOutput()
        {
            outputStatsStr = String.Join(Environment.NewLine, finalStats);
            box_Stats.Text = outputStatsStr;
        }
        public void ListOutput()
        {
            finalList.Sort();
            outputListStr = String.Join(Environment.NewLine, finalList);
            box_List.Text = outputListStr;
        }

        // Method for choosing which Stats output to display
        public void StatsOutputSelector()
        {
            if (rdo_Words.Checked == true)
            {
                if (chkBox_Unique.Checked == false)
                {
                    finalStats = wordStats;
                }
                else
                {
                    finalStats = uniqueWordStats;
                }
            }
            if (rdo_WordPairs.Checked == true)
            {
                if (chkBox_Unique.Checked == false)
                {
                    finalStats = pairStats;
                }
                else
                {
                    finalStats = uniquePairStats;
                }
            }
            StatsOutput();
        }

        // Method for choosing which List output to display
        public void ListOutputSelector()
        {
            if (rdo_Words.Checked == true)
            {
                if (chkBox_Unique.Checked == false)
                {
                    finalList = wordList;
                }
                if (chkBox_Unique.Checked == true)
                {
                    if (chkBox_Frequency.Checked == false)
                    {
                        finalList = uniqueWordList;
                    }
                    else
                    {
                        finalList = uniqueWordFreqList;
                    }
                }
            }

            if (rdo_WordPairs.Checked == true)
            {
                if (chkBox_Unique.Checked == false)
                {
                    finalList = pairList;
                }
                if (chkBox_Unique.Checked == true)
                {
                    if (chkBox_Frequency.Checked == false)
                    {
                        finalList = uniquePairList;
                    }
                    else
                    {
                        finalList = uniquePairFreqList;
                    }
                }
            }
            ListOutput();
        }

        public void StartUpValues()
        {
            charCount = 0;
            sentenceCount = 0;
            wordCount = 0;
            uniqueCount = 0;
            avgWordLength = 0;
            avgUniqueWordLength = 0;
            avgWordPairLength = 0;
            wordPairCount = 0;
            totalWordPairLength = 0;
            uniquePairCount = 0;
            totalUniquePairLength = 0;
            avgUniquePairLength = 0;

            wordList.Clear();
            uniqueWordList.Clear();
            uniquePairFreqList.Clear();
            pairList.Clear();
            uniquePairList.Clear();
            uniquePairFreqList.Clear();

            wordStats.Clear();
            uniqueWordStats.Clear();
            pairStats.Clear();
            uniquePairStats.Clear();

            errorList.Clear();

            finalList.Clear();
            finalStats.Clear();
        }

        public void UpdateOutput()
        {
            validatedStr = Validator(box_Input.Text);
            StartUpValues();
            Words(validatedStr);
            Pairs(validatedStr);
        }

        private void rdo_Words_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
            ListOutputSelector();
            if (!(string.IsNullOrEmpty(box_Stats.Text)))
            {
                StatsOutputSelector();
            }
        }

        private void rdo_WordPairs_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
            ListOutputSelector();
            if (!(string.IsNullOrEmpty(box_Stats.Text)))
            {
                StatsOutputSelector();
            }
        }

        private void chkBox_Unique_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
            if (chkBox_Unique.Checked == true)
            {
                chkBox_Frequency.Visible = true;
                chkBox_Frequency.Enabled = true;
                ListOutputSelector();
                if (!(string.IsNullOrEmpty(box_Stats.Text)))
                {
                    StatsOutputSelector();
                }
            }
            else
            {
                chkBox_Frequency.Visible = false;
                chkBox_Frequency.Enabled = false;
                chkBox_Frequency.Checked = false;
            }
        }

        private void chkBox_Frequency_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutput();
            ListOutputSelector();
            if (!(string.IsNullOrEmpty(box_Stats.Text)))
            {
                StatsOutputSelector();
            }
        }


        public void Error(int a)
        {
            if (a == 0)
            {
                errorOutput = String.Join("\n", errorList);
                box_Input.Text = errorOutput;
            }
            if (a == 1)
            {
                errorList.Add("Your input is too long.");
            }
            if (a == 2)
            {
                errorList.Add("Your input is using an improper format");
            }
            if (a == 3)
            {
                errorList.Add("Input cannot be empty.");
            }
            if (a == 4)
            {
                errorList.Add("Numbers can not be negative.");
            }
            if (errorList.Count > 0)
                return;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            box_Input.Text = "";
            box_Stats.Text = "";
            box_List.Text = "";
            StartUpValues();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
