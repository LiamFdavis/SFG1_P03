using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] float _rateOfFire = 1f;
    [SerializeField] bool _limitedAmmo = false;
    [SerializeField] int _maxAmmo = 10;
    [SerializeField] bool _canReload = false;
    [SerializeField] float _reloadSpeed = 1f;
    [SerializeField] GameObject _projectile = null;

    bool canShoot = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot == true)
        {
            GameObject nprojectile = Instantiate(_projectile, transform.position, transform.rotation);
        }
    }
}
