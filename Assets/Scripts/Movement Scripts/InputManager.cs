using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;

    private Tweener tweener;
    
    void Start()
    {
        tweener = GetComponent<Tweener>(); 
        Invoke("Move", 7);
    }
    
    
    void Move()
    {
        tweener.AddTween(item.transform, item.transform.position, new Vector3(3.52f, 6.16f, 0.0f), 3.5f);
        
        // tweener.AddTween(item.transform, item.transform.position, new Vector3(-6.78f, 9.51f, 0.0f), 3.5f);
// =======
        // tweener.AddTween(item.transform, item.transform.position, new Vector3(-6.78f, 13.47f, 0.0f), 3.0f);
//         tweener.AddTween(item.transform, item.transform.position, new Vector3(-6.78f, 9.51f, 0.0f), 3.0f);
// >>>>>>> Stashed changes
    }
}
