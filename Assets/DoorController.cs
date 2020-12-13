using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //doorを開けるアニメーション
    public Animator doorOpen;
    private bool isDoorOpen = false;
    public bool lockState = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isDoorOpen)
        {
            this.doorOpen.SetTrigger("Open");
        }
    }
    public void OpenDoor()
    {
        if(this.lockState)
        this.isDoorOpen = true;
    }
}
