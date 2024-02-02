using UnityEngine;
using TMPro;

public class ZedWordUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI wordText;

    public void SetWordText(string word)
    {
        wordText.text = word;
    }
}
