using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskController : MonoBehaviour
{
    private Animator deskAnimator;
    private GameObject mCamera;
    private CameraController cScript;

    // Start is called before the first frame update
    void Start()
    {
        this.deskAnimator = GetComponent<Animator>();
        this.mCamera = GameObject.Find("Main Camera");
        this.cScript = this.mCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DrawerStateChange1()
    {
        if (this.cScript.zoomState[3])
        {
            this.deskAnimator.SetBool("Open1", !this.deskAnimator.GetBool("Open1"));
        }
    }
    public void DrawerStateChange2()
    {
        if (this.cScript.zoomState[3])
        { 
            this.deskAnimator.SetBool("Open2", !this.deskAnimator.GetBool("Open2"));
        }           
    }
    public void DrawerStateChange3()
    {
        if (this.cScript.zoomState[3])
        {
            this.deskAnimator.SetBool("Open3", !this.deskAnimator.GetBool("Open3"));
        }
    }
}