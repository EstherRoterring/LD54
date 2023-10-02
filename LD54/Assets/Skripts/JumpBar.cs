using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpBar : MonoBehaviour
{

    //PlayerMovement.availableJumps 
    public Image[] jumps;
    public int anzahlMaxSprünge;
    public PlayerMovement pm;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < jumps.Length; i++)
        {
            if (i < pm.availableJumps)
            {
                jumps[i].enabled = true;
            }
            else
            {
                jumps[i].enabled = false;
            }
        }
    }
}
