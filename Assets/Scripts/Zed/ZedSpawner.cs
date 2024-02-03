using UnityEngine;

public class ZedSpawner : MonoBehaviour
{
    [SerializeField] private Transform zedParentTransform;
    [SerializeField] private GameObject zedPrefab;

    public Zed SpawnZed()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-25f, 25f), 0, 27f);

        GameObject newZed = Instantiate(zedPrefab, randomPosition, Quaternion.identity, zedParentTransform);
        Zed zed = newZed.GetComponent<Zed>();

        return zed;
    }
}
