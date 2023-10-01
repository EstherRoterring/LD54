using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tasteD;
    public GameObject tasteA;
    public GameObject tasteSpace;
    public GameObject tasteSlide;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            Destroy(tasteD);
        }
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            Destroy(tasteA);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(tasteSpace);
        }
        if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
        {
            Destroy(tasteSlide);
        }
    }
}
