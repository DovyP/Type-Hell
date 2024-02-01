using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WordGenerator))]
public class WordManager : MonoBehaviour
{
    [SerializeField] private List<Word> wordList;

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
}
