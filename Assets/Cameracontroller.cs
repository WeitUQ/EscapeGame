using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private GameObject door;
    private GameObject MCamera;
    private GameObject rButton;
    private GameObject lButton;
    private GameObject bButton;
    public bool[] zoomState;
    private Vector3 startPos;
    private Vector3 startAng;
    // Start is called before the first frame update
    void Start()
    {
        this.MCamera = GameObject.Find("Main Camera");
        this.door = GameObject.Find("Door");
        this.rButton = GameObject.Find("RightButton");
        this.lButton = GameObject.Find("LeftButton");
        this.bButton = GameObject.Find("BackButton");
        this.bButton.SetActive(false);
        this.startPos = this.transform.position;
        this.startAng = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void RAngleChange()
    {
        this.MCamera.transform.Rotate(0, 90, 0);
    }
    public void LAngleChange()
    {
         this.MCamera.transform.Rotate(0, -90, 0);
    }
    public void DoorZoomCamera()
    {
        if (this.zoomState[0] == false)
        {
            this.zoomState[0] = true;
            this.MCamera.transform.Rotate(5, -45, 0);
            this.MCamera.transform.position = new Vector3(this.door.transform.position.x, 15, -38);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);        }
    }
    public void BackCamera()
    {
        if (this.zoomState[0])
        {
            this.zoomState[0] = false;
            this.MCamera.transform.eulerAngles = this.startAng;
            this.MCamera.transform.position = this.startPos;
            this.rButton.SetActive(true);
            this.lButton.SetActive(true);
            this.bButton.SetActive(false);
        }
    }
}
