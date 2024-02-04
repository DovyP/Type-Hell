using UnityEngine;

public class Zed : MonoBehaviour
{
    [SerializeField] private ZedWordUI zedWordUI;
    [SerializeField] private Transform shootPoint;

    private float zedSpeed;

    private void Start()
    {
        zedSpeed = Random.Range(0.5f, 2f);
    }

    private void Update()
    {
        transform.Translate(0f, 0f, -zedSpeed * Time.deltaTime);
    }

    public void KillZed()
    {
        Destroy(gameObject);
    }

    public ZedWordUI GetZedWordUI()
    {
        return zedWordUI;
    }

    public Transform GetShootPoint()
    {
        return shootPoint;
    }
}
