using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTools : MonoBehaviour
{
    public static Vector3 ConstrainHookToScreen(SpriteRenderer hookRenderer)
    {

        Vector3 screenPosition = Camera.main.WorldToScreenPoint(hookRenderer.transform.position);

      
        if (screenPosition.x < -9)
            screenPosition.x = -9;
        if (screenPosition.y > 470)
            screenPosition.y = 470;
        if (screenPosition.y < 50)
            screenPosition.y = 50;
        /*
        if (screenPosition.y > 470)
            screenPosition.y = 470;
        if (screenPosition.y < 50)
            screenPosition.y = 50;
        */
        return Camera.main.ScreenToWorldPoint(screenPosition);
    }
}
