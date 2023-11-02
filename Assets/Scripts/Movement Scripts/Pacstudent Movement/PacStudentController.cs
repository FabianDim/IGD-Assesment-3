using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
        private Tweener tweener;
        [SerializeField] private GameObject pacStudent;
        private KeyCode lastkey;
        private Vector3 validPos;
        [SerializeField] private float gridUnit = 1.0f;

        void Start()
        {
            tweener = GetComponent<Tweener>();


        }

        private void Update()
        {
            // register key input to last input
            // if no active tweens start tween in dir if last input
            // if active tween cancel out of update

            // in start tween check if position valid
            // if no valid location in dir stop
            // raycast with layer mask to find walls
                if (tweener.activeTween == null)
                {
                    if (Input.GetKey(KeyCode.W))
                    {
                        lastkey = KeyCode.W;
                        Vector3 targetPosition = pacStudent.transform.position + Vector3.up * gridUnit;
                        MoveToTargetPosition(targetPosition);
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        lastkey = KeyCode.D;
                        Vector3 targetPosition = pacStudent.transform.position + Vector3.right * gridUnit;
                        MoveToTargetPosition(targetPosition);
                    }
                }
    }
        private void MoveToTargetPosition(Vector3 targetPosition)
        {
            if (IsPositionValid(targetPosition))
            {
                tweener.AddTween(pacStudent.transform, pacStudent.transform.position, targetPosition, 3.0f);
            }
        }

        private bool IsPositionValid(Vector3 position)
        {
            return true;
        }
}