using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WordReader))]
public class WordManager : MonoBehaviour
{
    [SerializeField] private int wordAmount = 5;

    private List<Word> parsedWordList = new List<Word>();

    private bool hasActiveWord;
    private Word activeWord;

    private WordReader wordReader;
    private ZedSpawner zedSpawner;

    private void Awake()
    {
        wordReader = GetComponent<WordReader>();
        zedSpawner = GetComponent<ZedSpawner>();
    }

    private void Start()
    {
        wordReader.ReadWordsFromData();

        for (int i = 0; i < wordAmount; i++) 
        {
            InsertWord();
        }
    }

    private void InsertWord()
    {
        //ZedWordUI zedWordUI = zedSpawner.SpawnZed();

        Word word = new Word(wordReader.GetRandomWordFromDataList(), zedSpawner.SpawnZed());
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
