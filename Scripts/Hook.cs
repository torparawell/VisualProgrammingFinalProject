using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    private SpriteRenderer HookSpriteRenderer;
    public GameObject fishingRod;


    void Awake()
    {
        HookSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
 
    }

    void Start()
    { 
        Cursor.visible = false;
    }
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        HookSpriteRenderer.transform.position = new Vector3(HookSpriteRenderer.transform.position.x, GetMouseYPosition(), HookSpriteRenderer.transform.position.z);
       ConstrainHookToScreen();
    }

    private float GetMouseYPosition()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        return worldPosition.y;
    }

    private void ConstrainHookToScreen()
    {
        HookSpriteRenderer.transform.position = GetRodPosition();
    }

    private Vector3 GetRodPosition()
    {
        Vector3 RodPosition = Camera.main.WorldToScreenPoint(fishingRod.transform.position);
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(HookSpriteRenderer.transform.position);

        if (screenPosition.y > RodPosition.y)
            screenPosition.y = RodPosition.y;
        if (screenPosition.y < 5)
            screenPosition.y = 5;

        return Camera.main.ScreenToWorldPoint(screenPosition);
    }

}
