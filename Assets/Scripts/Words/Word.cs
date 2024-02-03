[System.Serializable]
public class Word
{
    public string word;
    private int characterIndex;

    private ZedWordUI zedWordUI;
    private Zed zed;
    /*ZedWordUI zedWordUI*/
    public Word(string word, Zed zed)
    {
        this.word = word;
        characterIndex = 0;
        //this.zedWordUI = zedWordUI;
        this.zed = zed;
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
