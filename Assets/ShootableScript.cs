using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableScript : MonoBehaviour
{
    [SerializeField] int _DamageReduction = 2;
    [SerializeField] HealthScript _parentObject = null;
    int _damage = 0;
    ProjectileScript _hitProjectile;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if (collision.gameObject.GetComponent<ProjectileScript>() != null)
        {
            _hitProjectile = collision.gameObject.GetComponent<ProjectileScript>();

            _damage = _hitProjectile._projectileDamage - _DamageReduction;
            if( _damage > 0)
            {
                _parentObject.TakeDamage(_damage);
            }
            Destroy(collision.gameObject);
        }
        
    }

}
