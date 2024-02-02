using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WordReader))]
public class WordManager : MonoBehaviour
{
    private List<Word> parsedWordList = new List<Word>();

    private bool hasActiveWord;
    private Word activeWord;

    private WordReader wordReader;

    private void Awake()
    {
        wordReader = GetComponent<WordReader>();
    }

    private void Start()
    {
        wordReader.ReadWordsFromData();

        for (int i = 0; i < 300; i++) 
        {
            InsertWord();
        }
    }

    private void InsertWord()
    {
        Word word = new Word(wordReader.GetRandomWordFromDataList());
        Debug.Log(word.word);

        parsedWordList.Insert(0, word);
    }

    public void TypeCharacter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextCharacter() == letter)
            {
                activeWord.TypeCharacter();
            }
        }
        else
        {
            foreach (Word word in parsedWordList)
            {
                if (word.GetNextCharacter() == letter)
                {
                    activeWord = word;
                    Debug.Log("Active word: " + activeWord.word);
                    hasActiveWord = true;
                    word.TypeCharacter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            Debug.Log("Remove from list: " + activeWord.word);
            parsedWordList.Remove(activeWord);
        }
    }
}
