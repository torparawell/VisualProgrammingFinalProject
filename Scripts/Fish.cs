using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : DelayedObjectPlacer
{
    GameObject fish;

    protected override void InitializeParameters()
    {
        minimumTimeToNextCreation = 2f;
        maximumTimeToNextCreation = UnityEngine.Random.Range(8, 24);
    }

    public override void Create()
    {
        base.Create();
        fish = Instantiate(Prefab, ScreenPositionTools.RandomWorldLocation(Camera), Quaternion.identity);
    }
}
