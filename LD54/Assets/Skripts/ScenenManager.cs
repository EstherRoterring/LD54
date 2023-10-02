using System;
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
        if (Input.GetKeyUp(KeyCode.R))
        {
            ResetScene();
        }
    }

    public void GoToGameScene(){
        SceneManager.LoadScene("CutScene Mama");
    }
    

    public void GoToMenu(){
        SceneManager.LoadScene("TitleScene");
    }

    public void Exit(){
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
