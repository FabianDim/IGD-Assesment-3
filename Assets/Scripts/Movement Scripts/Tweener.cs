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
    // Start is called before the first frame update
// <<<<<<< Updated upstream
// =======
    
    private Animator _animator;
// >>>>>>> Stashed changes

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        
    }

// // <<<<<<< Updated upstream
// =======
    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

// >>>>>>> Stashed changes
    // Update is called once per frame
    void Update()
    {
        if (activeTween != null)
        {
            float distanceToTarget = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);
            if (distanceToTarget > 0.1f)
            {
// <<<<<<< Updated upstream
// =======
                _animator.ResetTrigger("Direction");
// >>>>>>> Stashed changes
                float timeFraction = (Time.time - activeTween.StartTime) / activeTween.Duration;

                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, timeFraction);
            }

            if (distanceToTarget <= 0.1f)
            {
// <<<<<<< Updated upstream
// =======
                _animator.SetTrigger("Direction");
// >>>>>>> Stashed changes
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