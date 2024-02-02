using UnityEngine;

[RequireComponent(typeof(WordManager))]
public class TypeInput : MonoBehaviour
{
    public WordManager wordManager;

    // Update is called once per frame
    void Update()
    {
        foreach (char character in Input.inputString)
        {
            wordManager.TypeCharacter(character);
        }
    }
}
