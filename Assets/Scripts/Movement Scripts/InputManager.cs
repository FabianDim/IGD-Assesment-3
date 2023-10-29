using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject borderItem;

    private Tweener tweener;
    
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    private void Update()
    {
        MoveRight();
    }


    void MoveRight()
    {
        tweener.AddTween(borderItem.transform, borderItem.transform.position, new Vector3(1152f, 541f, 0.0f), 10f);
    }
}
