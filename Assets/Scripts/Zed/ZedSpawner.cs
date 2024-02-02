using UnityEngine;

public class ZedSpawner : MonoBehaviour
{
    [SerializeField] private GameObject zedPrefab;

    public ZedWordUI SpawnZed()
    {
        GameObject newZed = Instantiate(zedPrefab);
        ZedWordUI zedWordUI = newZed.GetComponentInChildren<ZedWordUI>();

        return zedWordUI;
    }
}
