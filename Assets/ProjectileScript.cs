using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    [SerializeField] float _projectileSpeed = 3f;
    [SerializeField] public int _projectileDamage = 1;
    private void FixedUpdate()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.position += transform.forward * Time.deltaTime * _projectileSpeed;
    }

}
