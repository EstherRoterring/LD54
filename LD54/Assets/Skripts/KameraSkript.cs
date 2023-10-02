using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class KameraSkript : MonoBehaviour
{
    public CinemachineVirtualCamera VcCamera;
    public GameObject player;
    public GameObject ziel;
    public float cameraSize = 4;
    public float zoomedCameraSize = 8;
    
    public KeyCode zoomOut;
    public KeyCode zielAnzeigen;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Kamera zoomt raus
        if (Input.GetKey(zoomOut))
        {
            
            VcCamera.m_Lens.OrthographicSize = zoomedCameraSize;
        }
        else
        {
            VcCamera.m_Lens.OrthographicSize = cameraSize;
        }

        //Kamera zeigt Ziel
        if (Input.GetKey(zielAnzeigen))
        {
            VcCamera.m_Lens.OrthographicSize = zoomedCameraSize;
            VcCamera.Follow = ziel.transform;
        }
        else
        {
            VcCamera.Follow = player.transform;
        }
        
    }
}
