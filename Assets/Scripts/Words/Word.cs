using System;

[Serializable]
public class Word
{
    public string word;
    private int typeIndex;

    public Word(string word)
    {
        this.word = word;
        typeIndex = 0;
    }

    public char GetNextCharacter()
    {
        return word[typeIndex];
    }

    public void TypeCharacter()
    {
        typeIndex++;
        // Remove the letter on screen
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);

        if (wordTyped)
        {
            // Remove the word on screen
        }

        return wordTyped;
    }
}
