using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayShootingAnimation()
    {
        animator.Play("demo_combat_shoot", - 1, 0f);
    }
}
