namespace T9_Spelling.BLL
{
    public class Replace
    {
        /// <summary>
        /// Replace entered numbers on letters
        /// </summary>
        /// <param name="number">Number symbol</param>
        /// <returns>Letter symbol</returns>
        public char ReplaceNumbers(char number)
        {
            if (number == '2')
                number = 'A';
            else if (number == '3')
                number = 'D';
            else if (number == '4')
                number = 'G';
            else if (number == '5')
                number = 'J';
            else if (number == '6')
                number = 'M';
            else if (number == '7')
                number = 'P';
            else if (number == '8')
                number = 'T';
            else if (number == '9')
                number = 'W';
            else if (number == '0')
                number = ' ';

            return number;
        }

        /// <summary>
        /// Replace a group of characters on the right one
        /// </summary>
        /// <param name="text">Typed text from TextBox</param>
        /// <returns>Сorrect text</returns>
        public string ReplaceLetters(string text)
        {
            if (text.Contains("AAA"))
                text = text.Replace("AAA", "C");

            if (text.Contains("AA"))
                text = text.Replace("AA", "B");

            if (text.Contains("DDD"))
                text = text.Replace("DDD", "F");

            if (text.Contains("DD"))
                text = text.Replace("DD", "E");

            if (text.Contains("GGG"))
                text = text.Replace("GGG", "I");

            if (text.Contains("GG"))
                text = text.Replace("GG", "H");

            if (text.Contains("JJJ"))
                text = text.Replace("JJJ", "L");

            if (text.Contains("JJ"))
                text = text.Replace("JJ", "K");

            if (text.Contains("MMM"))
                text = text.Replace("MMM", "O");

            if (text.Contains("MM"))
                text = text.Replace("MM", "N");

            if (text.Contains("PPPP"))
                text = text.Replace("PPPP", "S");

            if (text.Contains("PPP"))
                text = text.Replace("PPP", "R");

            if (text.Contains("PP"))
                text = text.Replace("PP", "Q");

            if (text.Contains("TTT"))
                text = text.Replace("TTT", "V");

            if (text.Contains("TT"))
                text = text.Replace("TT", "U");

            if (text.Contains("WWWW"))
                text = text.Replace("WWWW", "Z");

            if (text.Contains("WWW"))
                text = text.Replace("WWW", "Y");

            if (text.Contains("WW"))
                text = text.Replace("WW", "X");

            return text;
        }
    }
}