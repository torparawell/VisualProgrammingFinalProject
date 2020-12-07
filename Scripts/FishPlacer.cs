using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPlacer : DelayedObjectPlacer
{
    GameObject fish;

    protected override void InitializeParameters()
    {
        minimumTimeToNextCreation = 1f;
        maximumTimeToNextCreation = 4f;
    }

    public override void Create()
    {
        base.Create();
        fish = Instantiate(Prefab, ScreenPositionTools.RandomWorldLocation(Camera), Quaternion.identity);
    }
}
