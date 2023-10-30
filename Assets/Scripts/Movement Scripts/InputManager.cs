using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject borderItems;
    

    private Tweener tweener;
    private Vector3 first = new Vector3(1152f, 541f, 0.0f);
    private Vector3 second = new Vector3(1152f, 795f, 0.0f);
    private Vector3 third = new Vector3(141.6f, 795f, 0.0f);
    
    void Start()
    {
        tweener = GetComponent<Tweener>();

        
    }

    private void Update()
    {
        Move();
    }


    void Move()
    {
        if (tweener.activeTween == null)
        {
            tweener.AddTween(borderItems.transform, borderItems.transform.position, new Vector3(1152f, 541f, 0.0f), 10f);
            if(borderItems.transform.position.Equals(first))
            {
                tweener.AddTween(borderItems.transform, borderItems.transform.position, new Vector3(1152f, 795f, 0.0f), 3f);
            }
            if(borderItems.transform.position.Equals(second))
            {
                
                tweener.AddTween(borderItems.transform, borderItems.transform.position, new Vector3(141.6f, 795f, 0.0f), 10f);
            }
            if(borderItems.transform.position.Equals(third))
            {
                
                tweener.AddTween(borderItems.transform, borderItems.transform.position, new Vector3(141.6f, 541f, 0.0f), 3f);
            }
            

        }
        
    }
}
