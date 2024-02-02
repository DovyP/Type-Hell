using UnityEngine;

public class ZedSpawner : MonoBehaviour
{
    [SerializeField] private Transform zedParentTransform;
    [SerializeField] private GameObject zedPrefab;

    public ZedWordUI SpawnZed()
    {
        GameObject newZed = Instantiate(zedPrefab, zedParentTransform);
        ZedWordUI zedWordUI = newZed.GetComponentInChildren<ZedWordUI>();

        return zedWordUI;
    }
}
