using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] float _rateOfFire = 1f;
    [SerializeField] bool _limitedAmmo = false;
    [SerializeField] int _maxAmmo = 10;
    [SerializeField] bool _canReload = false;
    [SerializeField] float _reloadSpeed = 5f;
    [SerializeField] GameObject _projectile = null;

    bool canShoot = true;
    float coolDown = 1;
    int CurrentAmmo = 10;
    float reloadTimer = 5f;
    bool reloading = false;
    private void Start()
    {
        coolDown = _rateOfFire;
        CurrentAmmo = _maxAmmo;
        reloadTimer = _reloadSpeed;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot == true)
        {
            Shoot();
        }
        if(_limitedAmmo == false)
        {
            if (canShoot == false)
            {
                coolDown -= Time.deltaTime;
                if(coolDown <= 0)
                {
                    canShoot = true;
                    coolDown = _rateOfFire;
                }
            }
        }
        else if (_limitedAmmo == true)
        {
                if(CurrentAmmo > 0)
                {
                    if (canShoot == false)
                    {
                        coolDown -= Time.deltaTime;
                        if (coolDown <= 0)
                        {
                            canShoot = true;
                            coolDown = _rateOfFire;
                        }
                    }
                }
        }
        if (Input.GetKeyDown(KeyCode.R) && _canReload == true)
        {
            Debug.Log("Reload");
            reloading = true;
        }
        if(reloading == true)
        {
            reloadTimer -= Time.deltaTime;
            if (reloadTimer <= 0)
            {
                Debug.Log("Reloaded");
                CurrentAmmo = _maxAmmo;
                reloadTimer = _reloadSpeed;
                reloading = false;
            }
        }
 
    }

    private void Shoot()
    {
        GameObject nprojectile = Instantiate(_projectile, transform.position, transform.rotation);
        canShoot = false;
        CurrentAmmo -= 1;
        
    }
}
