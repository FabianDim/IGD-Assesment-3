// <<<<<<< Updated upstream
// =======
using System;
// >>>>>>> Stashed changes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;

    private Animator _animator;


    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        
    }
    
    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    
    void Update()
    {
        if (activeTween != null)
        {
            float distanceToTarget = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);
            if (distanceToTarget > 0.1f)
            {

                _animator.ResetTrigger("Direction");

                float timeFraction = (Time.time - activeTween.StartTime) / activeTween.Duration;

                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, timeFraction);
            }

            if (distanceToTarget <= 0.1f)
            {
                _animator.SetTrigger("Direction");

                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }
        else
        {
            return;
        }
    }
}
