using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(WordGenerator))]
public class WordManager : MonoBehaviour
{
    [SerializeField] private List<Word> wordList;

    private bool hasActiveWord;
    private Word activeWord;

    private WordGenerator wordGenerator;

    private void Awake()
    {
        wordGenerator = GetComponent<WordGenerator>();
    }

    private void Start()
    {
        for (int i = 0; i < 300; i++)
        {
            AddWord();
        }
    }

    private void AddWord()
    {
        Word word = new Word(wordGenerator.GetRandomWord());
        wordList.Add(word);
    }

    private void TypeCharacter(char character)
    {
        if (hasActiveWord)
        {
            // Check if letter was next
            if(activeWord.GetNextCharacter() == character)
            {
                activeWord.TypeCharacter();
            }
                // Remove it from the word
        }
        else
        {
            foreach(Word word in wordList)
            {
                if(word.GetNextCharacter() == character)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeCharacter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            wordList.Remove(activeWord);
        }
    }
}
