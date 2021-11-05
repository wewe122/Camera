using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.IK;
using UnityEngine;

public class minimappos : MonoBehaviour
{
    

   //אנחנו לא רוצים שתזוזת המצלמה הקטנה תחרוג מגבולות המשחק
   //בגלל שהמצלמה תלויה במיקום השחקן והשחקן מגיע לנקודה שיכולה לגרום למצלמה לצאת
   //הגדרנו קבוע עבור מיקום המצלמה הקטנה שישמש כגבול
    public Transform player;
    private float LimitForMiniMap = 5.835996f;
    void FixedUpdate()
    {

        Vector3 newpos = player.position;
        newpos.y = transform.position.y;
        newpos.z = -10;
        if(newpos.x > 0 && newpos.x <= LimitForMiniMap) 
        {
            transform.position = newpos;
        }
        if(newpos.x < 0 && newpos.x >= -LimitForMiniMap)
        {
            transform.position = newpos;
        }

        
        
    }
}
