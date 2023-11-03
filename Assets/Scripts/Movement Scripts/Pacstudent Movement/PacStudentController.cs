using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    private Tweener tweener;
    [SerializeField] private GameObject pacStudent;
    private GameObject[] pellets;
    private KeyCode lastInput;
    private Vector3 searchDirection;

    private void pelletSearch()
    {
        if (lastInput == KeyCode.D)
        {
            searchDirection = Vector3.right;
        }
        if (lastInput == KeyCode.A)
        {
            searchDirection = Vector3.left;
        }
        if (lastInput == KeyCode.W)
        {
            searchDirection = Vector3.up;
        }
        if (lastInput == KeyCode.S)
        {
            searchDirection = Vector3.down;
        }
        
    }

    private GameObject nearestPellet;

    void Start()
    {
        pellets = GameObject.FindGameObjectsWithTag("Pellet");
        tweener = GetComponent<Tweener>();

        UpdateNearestPelletInDirection(searchDirection);
    }

    void Update()
    {
        // Example: Check for the nearest pellet in a specified direction every frame
        if (Input.GetKey(KeyCode.D))
        {
            lastInput = KeyCode.D;
        }
        if (Input.GetKey(KeyCode.A))
        {
            lastInput = KeyCode.A;
        }
        if (Input.GetKey(KeyCode.W))
        {
            lastInput = KeyCode.W;
        }
        if (Input.GetKey(KeyCode.S))
        {
            lastInput = KeyCode.S;
        }
        Debug.Log("Last Input: " + lastInput);
        Tween();
    }

    void UpdateNearestPelletInDirection(Vector3 direction)
    {
        float minDistance = float.MaxValue;
        nearestPellet = null;

        foreach (var pellet in pellets)
        {
            Vector3 toPellet = pellet.transform.position - pacStudent.transform.position;
            float distance = Vector3.Distance(pacStudent.transform.position, pellet.transform.position);

            // Check if the pellet is in the specified direction and closer
            if (Vector3.Dot(toPellet.normalized, direction) > 0 && distance < minDistance)
            {
                minDistance = distance;
                nearestPellet = pellet;
            }
        }

        if (nearestPellet != null)
        {
            Debug.Log("Nearest pellet in direction: " + nearestPellet.name);
        }
    }

    void Tween()
    {
        if (tweener.activeTween == null)
        {
            Debug.Log("Tween called");
            if (nearestPellet != null)
            {
                Vector3 targetPosition = nearestPellet.transform.position;
                tweener.AddTween(pacStudent.transform, pacStudent.transform.position, targetPosition, 1f);
            }
        }
    }

}