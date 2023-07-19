using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefeb;
    public Transform launchPoint;

    public void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefeb, launchPoint.position, projectilePrefeb.transform.rotation);
        Vector3 oriScale = projectile.transform.localScale;

        float dir = transform.localScale.x > 0 ? 1 : -1;

        projectile.transform.localScale = new Vector3(
            oriScale.x * dir,
            oriScale.y * dir,
            oriScale.z
            );

    }
}
