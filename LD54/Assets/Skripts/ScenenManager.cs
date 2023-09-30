using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToGameScene()
    {
        //Whatever we need here
        SceneManager.LoadScene("GameScene00");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
    
}