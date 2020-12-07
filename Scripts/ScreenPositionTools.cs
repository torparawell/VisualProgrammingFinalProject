using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPositionTools : MonoBehaviour
{
    public static Vector3 RandomWorldLocation(Camera camera)
    {
        Vector3 screenLocation = RandomScreenLocation();
        Vector3 worldLocation = camera.ScreenToWorldPoint(screenLocation);

        return worldLocation;
    }

    public static Vector3 RandomScreenLocation()
    {
        float randomY = Random.Range(80, 300);

        return new Vector3(0, randomY, 10);
    }


}
