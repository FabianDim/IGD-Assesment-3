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
    
    private Quaternion rightRotation = Quaternion.Euler(0, 0, 0);
    private Quaternion upRotation = Quaternion.Euler(0, 0, 90);
    private Quaternion leftRotation = Quaternion.Euler(0, 0, 180);
    private Quaternion downRotation = Quaternion.Euler(0, 0, 270);

    void Start()
    {
        tweener = GetComponent<Tweener>();
        borderItems.transform.rotation = rightRotation;
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        if (tweener.activeTween == null)
        {
            if (borderItems.transform.position == first)
            {
                tweener.AddTween(borderItems.transform, borderItems.transform.position, second, 3f);
                borderItems.transform.rotation = upRotation;
            }
            else if (borderItems.transform.position == second)
            {
                tweener.AddTween(borderItems.transform, borderItems.transform.position, third, 10f);
                borderItems.transform.rotation = leftRotation;
            }
            else if (borderItems.transform.position == third)
            {
                tweener.AddTween(borderItems.transform, borderItems.transform.position, first, 3f);
                borderItems.transform.rotation = downRotation;
            }
            else
            {
                tweener.AddTween(borderItems.transform, borderItems.transform.position, first, 10f);
                borderItems.transform.rotation = rightRotation;
            }
        }
    }
}
