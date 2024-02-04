using System.Collections;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private LineRenderer bulletLineRenderer;
    [SerializeField] private Transform bulletLineOrigin;
    [SerializeField] private float bulletLineDuration;
    [SerializeField] private PlayerAnimations playerAnimations;

    private void Start()
    {
        WordManager.onCharacterType += WordManager_onCharacterType;
    }

    private void WordManager_onCharacterType(Transform obj)
    {
        ShootLine(obj);
    }

    public void ShootLine(Transform shootPoint)
    {
        bulletLineRenderer.SetPosition(0, bulletLineOrigin.position);
        bulletLineRenderer.SetPosition(1, shootPoint.position);
        StartCoroutine(ActivateLine());
        playerAnimations.PlayShootingAnimation();
    }

    IEnumerator ActivateLine()
    {
        bulletLineRenderer.enabled = true;
        yield return new WaitForSeconds(bulletLineDuration);
        bulletLineRenderer.enabled = false;
    }
}
