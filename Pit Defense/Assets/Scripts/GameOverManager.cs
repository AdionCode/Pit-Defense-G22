using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    public int Health = 5;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health < 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(0);
        }
    }
}
