﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour
{
    public Animator bedAnimator;
    public CameraController cScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PillowStateChange()
    {
        if (this.cScript.zoomState[9])
        {
            this.bedAnimator.SetBool("pillowMove", !this.bedAnimator.GetBool("pillowMove"));
        }
    }
}
