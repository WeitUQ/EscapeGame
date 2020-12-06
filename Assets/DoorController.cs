using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //doorに鍵が刺さっているか、ドアノブがついているかで分岐
    private GameObject door;
    //doorを開けるアニメーション
    private Animator doorOpen;
    private bool isDoorOpen = false;
    public bool lockState = false;
    // Start is called before the first frame update
    void Start()
    {
        this.door = GameObject.Find("Door");
        this.doorOpen = GetComponent<Animator>();
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
