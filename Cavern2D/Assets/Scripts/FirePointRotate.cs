using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointRotate : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        // Makes the firepoint rotate at the position your mouse is, and therefore
        // you'll be able to shoot on the direction where your mouse is.

        Vector3 mousepos = Input.mousePosition;

        Vector3 gunposition = Camera.main.WorldToScreenPoint(transform.position);

        mousepos.x = mousepos.x - gunposition.x;
        mousepos.y = mousepos.y - gunposition.y;

        float gunangle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg;

        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunangle));         
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunangle));
        }
       

        
    }
}
