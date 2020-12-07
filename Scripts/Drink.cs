using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : DelayedObjectPlacer
{
    GameObject drink;
    protected override void InitializeParameters()
    {
        minimumTimeToNextCreation = 5f;
        maximumTimeToNextCreation = 9f;
    }

    public override void Create()
    {
        base.Create();
        drink = Instantiate(Prefab, ScreenPositionTools.RandomWorldLocation(Camera), Quaternion.identity);
    }
}
