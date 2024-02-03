using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WordReader))]
public class WordManager : MonoBehaviour
{
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
    }

    public void InsertWord()
    {
        Zed zed = zedSpawner.SpawnZed();
        ZedWordUI zedWordUI = zed.GetZedWordUI();

        Word word = new Word(wordReader.GetRandomWordFromDataList(), zedWordUI, zed);

        parsedWordList.Add(word);
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
