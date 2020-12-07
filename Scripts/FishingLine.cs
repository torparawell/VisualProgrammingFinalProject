using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FishingLine : MonoBehaviour
{
    private LineRenderer fishingLine;
    private Transform hookParent;
    public GameObject fishingRod;

    private void Awake()
    {
        hookParent = transform.parent;
        fishingLine = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        AttachToHook();
    }

    public void Update()
    {
        UpdateLinelength();
    }
    

    private void UpdateLinelength()
    {
        fishingLine.SetPosition(1, hookParent.position);
    }

    public void AttachToHook()
    {
        fishingLine.SetPosition(0, hookParent.position);
    }

}


   
