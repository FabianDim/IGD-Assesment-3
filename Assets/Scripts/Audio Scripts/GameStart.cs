using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] private AudioSource _gameIntro;
    [SerializeField] private AudioSource _gameBack;

    private bool _isDone;
    // Start is called before the first frame update
    void Start()
    {
        _gameIntro.Play();
        _gameBack.PlayDelayed(7);
    }

    // Update is called once per frame
    void Update()
    {
        _gameBack.loop = true;
    }
}
