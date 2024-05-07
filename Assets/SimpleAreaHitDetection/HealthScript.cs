using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] int _HP = 10;

    public void TakeDamage(int damage)
    {
        _HP -= damage;
        Debug.Log(_HP);
    }

    private void Update()
    {
        if (_HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
