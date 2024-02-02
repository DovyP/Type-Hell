[System.Serializable]
public class Word
{
    public string word;
    private int characterIndex;

    private ZedWordUI zedWordUI;

    public Word(string word, ZedWordUI zedWordUI)
    {
        this.word = word;
        characterIndex = 0;
        this.zedWordUI = zedWordUI;
        zedWordUI.SetWordText(word);
    }

    public char GetNextCharacter()
    {
        return word[characterIndex];
    }

    public void TypeCharacter()
    {
        characterIndex++;
        zedWordUI.RemoveCharacter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (characterIndex >= word.Length);

        if (wordTyped)
        {
            zedWordUI.RemoveZed();
        }

        return wordTyped;
    }
}
