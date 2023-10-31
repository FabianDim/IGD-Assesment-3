using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene(1);
        // UnityEditor.EditorApplication.isPlaying = false;
    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            Button Level1 = GameObject.FindWithTag("Level1").GetComponent<Button>();
            Button exit = GameObject.FindWithTag("QuitButton").GetComponent<Button>();
            exit.onClick.AddListener(QuitGame);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
