namespace T9_Spelling.BLL
{
    public interface IReplace
    {
        /// <summary>
        /// Replace entered numbers on letters
        /// </summary>
        /// <param name="number">Number symbol</param>
        /// <returns>Letter symbol</returns>
        char ReplaceNumbers(char number);

        /// <summary>
        /// Replace a group of characters on the right one
        /// </summary>
        /// <param name="text">Typed text from TextBox</param>
        /// <returns>Сorrect text</returns>
        string ReplaceLetters(string text);
    }
}
