using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAnim : MonoBehaviour
{
    
    private Animator _animator;
    private GameObject _death;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Dead", true);

    }
}

