using System.IO;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList;

    private void Start()
    {
        ReadWordsFromData();
    }

    public string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

    private void ReadWordsFromData()
    {
        Debug.Log("[In Progress] Reading words from the data...");

        wordList = File.ReadAllLines("Assets/Ext_Data/WordList.txt");

        Debug.Log("[Finished] Reading words from the data.");
    }
}
