using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private void Awake()
    {
        WordManager.onCharacterType += WordManager_onCharacterType;
    }

    private void WordManager_onCharacterType(Transform obj)
    {
        transform.LookAt(obj.position);

    }

    public void RotateTowards(Transform target)
    {
        transform.LookAt(target.position);
    }
}
