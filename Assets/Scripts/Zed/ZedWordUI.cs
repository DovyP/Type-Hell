using UnityEngine;
using TMPro;

public class ZedWordUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI wordText;
    //temporary
    [SerializeField] private GameObject zedParent;

    private float zedSpeed;

    private void Start()
    {
        zedSpeed = Random.Range(0.5f, 2f);
    }

    private void Update()
    {
        zedParent.transform.Translate(0f, 0f, -zedSpeed * Time.deltaTime);
    }

    public void SetWordText(string word)
    {
        wordText.text = word;
    }

    public void RemoveCharacter()
    {
        wordText.text = wordText.text.Remove(0, 1);
        wordText.fontMaterial.SetColor(ShaderUtilities.ID_GlowColor, new Color32(45, 255, 45, 255));
        wordText.fontMaterial.SetColor(ShaderUtilities.ID_OutlineColor, new Color32(45, 255, 45, 255));
        //wordText.ForceMeshUpdate();
        
    }

    //temporary
    public void RemoveZed() 
    {
        Destroy(zedParent);
    }
}
