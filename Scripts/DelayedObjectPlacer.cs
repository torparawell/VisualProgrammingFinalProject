using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedObjectPlacer : MonoBehaviour
{
    public GameObject Prefab;
    public Camera Camera;
    private bool isWaitingToCreate = false;

    protected float minimumTimeToNextCreation;
    protected float maximumTimeToNextCreation;
    protected float secondsUntilCreation = 0f;
    protected float moveDistance = 7f;

    void Start()
    {
        InitializeParameters();
    }

    public virtual void Create(Vector3 position)
    {
        GameObject newObject = Instantiate(Prefab, position, Quaternion.identity);
    }

    public virtual void Create()
    {
        isWaitingToCreate = false;
    }


    protected virtual void InitializeParameters()
    {
        minimumTimeToNextCreation = 2f;
        maximumTimeToNextCreation = 4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isWaitingToCreate)
        {
            StartWaitingToCreate();
        }
       
    }

    private void StartWaitingToCreate()
    {
        isWaitingToCreate = true;
        secondsUntilCreation = UnityEngine.Random.Range(minimumTimeToNextCreation, maximumTimeToNextCreation);
        StartCoroutine(CountdownUntilCreation());
    }

    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(secondsUntilCreation);
        Create();
    }



}
