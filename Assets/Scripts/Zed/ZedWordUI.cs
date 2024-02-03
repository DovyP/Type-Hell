using UnityEngine;
using TMPro;

public class ZedWordUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI wordText;
    [SerializeField] private GameObject wordIndicator;
    //temporary
    [SerializeField] private GameObject zedParent;

    public void SetWordText(string word)
    {
        wordText.text = word;
    }

    public void RemoveCharacter()
    {
        wordText.text = wordText.text.Remove(0, 1);
        wordText.fontMaterial.SetColor(ShaderUtilities.ID_GlowColor, new Color32(45, 255, 45, 255));
        wordText.fontMaterial.SetColor(ShaderUtilities.ID_OutlineColor, new Color32(45, 255, 45, 255));        
    }

    public void ActivateIndicator()
    {
        wordIndicator.SetActive(true);
    }
}
