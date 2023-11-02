using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class PacStudentController : MonoBehaviour
{
    // [SerializeField] private GameObject pacStudent;
    [SerializeField] private bool isRepeatedMovement = false;
    [SerializeField] private float moveDuration = 0.1f;
    [SerializeField] private float gridSize = 1f;
    private KeyCode _lastInput;

    private bool isMoving = false;
    
    void Start()
    {

        
    }

    private void Update()
    {

            if (Input.GetKey(KeyCode.W))
            {
                _lastInput = KeyCode.W;
                StartCoroutine(Move(Vector2.up));
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _lastInput = KeyCode.S;
                StartCoroutine(Move(Vector2.down));
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _lastInput = KeyCode.D;
                StartCoroutine(Move(Vector2.right));
            }
            else if (Input.GetKey(KeyCode.W))
            {
                _lastInput = KeyCode.A;
                while(_lastInput == KeyCode.A) {StartCoroutine(Move(Vector2.left));}
            }

    }
    private IEnumerator Move(Vector3 direction)
    {
        isMoving = true;
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + (direction * gridSize);
        float elapsedTime = 0;
        while (elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            float percent = elapsedTime / moveDuration;
            transform.position = Vector3.Lerp(startPosition, endPosition, percent);
            yield return null;
        }
        isMoving = false;
    }
        
}