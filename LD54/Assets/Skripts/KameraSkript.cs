using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class KameraSkript : MonoBehaviour
{
    public CinemachineVirtualCamera VcCamera;
    public GameObject player;
    public GameObject ziel;
    
    public KeyCode zoomOut;
    public KeyCode zielAnzeigen;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(zoomOut))
        {
            
            VcCamera.m_Lens.OrthographicSize = 8;
        }
        else
        {
            VcCamera.m_Lens.OrthographicSize = 4;
        }

        if (Input.GetKey(zielAnzeigen))
        {
            VcCamera.Follow = ziel.transform;
        }
        else
        {
            VcCamera.Follow = player.transform;
        }
    }
}
