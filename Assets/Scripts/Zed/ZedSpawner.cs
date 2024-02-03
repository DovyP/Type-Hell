using UnityEngine;

public class ZedSpawner : MonoBehaviour
{
    [SerializeField] private Transform zedParentTransform;
    [SerializeField] private GameObject zedPrefab;

    public ZedWordUI SpawnZed()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-25f, 25f), 0, 30f);

        GameObject newZed = Instantiate(zedPrefab, randomPosition, Quaternion.identity, zedParentTransform);
        ZedWordUI zedWordUI = newZed.GetComponentInChildren<ZedWordUI>();

        return zedWordUI;
    }
}
