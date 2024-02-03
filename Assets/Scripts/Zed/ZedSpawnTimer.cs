using UnityEngine;

public class ZedSpawnTimer : MonoBehaviour
{
    [SerializeField] WordManager wordManager;

    [SerializeField] private float zedDelay = 1.5f;
    private float nextZedTime = 0f;

    private void Update()
    {
        if (Time.time >= nextZedTime)
        {
            wordManager.InsertWord();
            nextZedTime = Time.time + zedDelay;
            zedDelay *= .99f;
        }
    }
}
