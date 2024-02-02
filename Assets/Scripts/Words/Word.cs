[System.Serializable]
public class Word
{
    public string word;
    private int characterIndex;

    public Word(string word)
    {
        this.word = word;
        characterIndex = 0;
    }

    public char GetNextCharacter()
    {
        return word[characterIndex];
    }

    public void TypeCharacter()
    {
        characterIndex++;
        // Remove the letter on screen
    }

    public bool WordTyped()
    {
        bool wordTyped = (characterIndex >= word.Length);

        if (wordTyped)
        {
            // Remove the word on screen
        }

        return wordTyped;
    }
}
