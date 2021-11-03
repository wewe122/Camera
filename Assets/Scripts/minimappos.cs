using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimappos : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;

    void FixedUpdate()
    {

        Vector3 newpos = player.position;
        newpos.y = transform.position.y;
        newpos.z = -10;
        if(newpos.x > 0 && newpos.x <= 5.835996)
        {
            transform.position = newpos;
        }
        if(newpos.x < 0 && newpos.x >= -5.835996)
        {
            transform.position = newpos;
        }

        
        
    }
}
