using System.IO;
using UnityEngine;

public class WordReader : MonoBehaviour
{
    private string[] wordList;

    public string GetRandomWordFromDataList()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

    public void ReadWordsFromData()
    {
        Debug.Log("[In Progress] Reading words from the data...");

        wordList = File.ReadAllLines("Assets/Ext_Data/WordList.txt");

        Debug.Log("[Finished] Reading words from the data.");
    }
}
