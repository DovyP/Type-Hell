using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    public void RotateTowards(Transform target)
    {
        transform.LookAt(target.position);
    }
}
