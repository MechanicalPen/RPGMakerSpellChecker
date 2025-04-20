using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NHunspellComponent.Spelling
{
    internal struct Word
    {
        private const string PATTERN_IS_DEVANAGARI = @"(\p{IsDevanagari}+)";
        public int Start;
        public int Length;
        private string text;

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                int l = text.Length;
                text = text.TrimStart(' ');
                Start = Start - (l - text.Length);
                text = text.Trim();
                Length = text.Length;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}){2}", Text, Start, Length);
        }

        public static Word GetWordFromPosition(string Text, int position)
        {
            Word result = new Word();
            SplitWord[] wordSplits = SplitTextIntoWords(Text);
            SplitWord wordAtPosition = GetWordStartingAt(wordSplits, position);
            result.Start = wordAtPosition.position;
            result.Length = wordAtPosition.word.Length;
            result.Text = Text.Substring(result.Start, result.Length).Replace("\n", "");
            return result;
        }

        private static SplitWord GetWordStartingAt(SplitWord[] words, int lookingPosition)
        {
            foreach (SplitWord word in words)
            {
                if (word.position <= lookingPosition && lookingPosition <= word.position + word.word.Length )
                {
                    return word;
                }
            }

            return new SplitWord("", lookingPosition);
        }

        private static SplitWord[] SplitTextIntoWords(string text)
        {
            // Regular expression to match words and contractions
            string pattern = @"\b\w+('\w+)?\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            List<SplitWord> SplitWords = new List<SplitWord>();
            for (int i = 0; i < matches.Count; i++)
            {
                // if it starts with \ (and not \\) then its a command code and not a real word.
                int slashIndex = matches[i].Index - 1;
                if (slashIndex >= 0 && text[slashIndex] == '\\')
                {
                    int cancelSlashIndex = slashIndex - 1;
                    if (cancelSlashIndex >= 0 && text[slashIndex] == '\\')
                    {
                        // double slash cancels the escape code and displays a slash. this is a word.
                    }
                    else
                    {
                        continue;
                    }
                }

                //otherwise its a word.
                SplitWord splitWord = new SplitWord(matches[i].Value, matches[i].Index);
                SplitWords.Add(splitWord);
            }

            return SplitWords.ToArray();
        }

        internal void Reset()
        {
            Start = 0;
            Length = 0;
            text = "";
        }
    }

    internal struct SplitWord
    {
        public string word;
        public int position;

        public SplitWord(string word, int position)
        {
            this.word = word;
            this.position = position;
        }

    }
}