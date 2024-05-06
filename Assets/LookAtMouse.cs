using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    private Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        Vector3 mousePos =  (Vector2)(cam.ScreenToWorldPoint(Input.mousePosition));
        float angleRad = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);
        float angleDeg =  (180 / Mathf.PI) * angleRad;

        transform.rotation = Quaternion.Euler(0f, angleDeg, 0f);
        Debug.DrawLine(transform.position, mousePos,Color.black, Time.deltaTime);
    }
}
