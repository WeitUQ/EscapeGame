using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private GameObject desk;
    private GameObject door;
    private GameObject MCamera;
    private GameObject rButton;
    private GameObject lButton;
    private GameObject bButton;
    public bool[] zoomState;
    private Vector3 startPos;
    private Vector3 startAng;
    private Vector3 interPos;
    private Vector3 interAng;
    // Start is called before the first frame update
    void Start()
    {
        this.MCamera = GameObject.Find("Main Camera");
        this.desk = GameObject.Find("Desk");
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
        this.startPos = this.transform.position;
        this.startAng = this.transform.eulerAngles;
    }
    public void LAngleChange()
    {
        this.MCamera.transform.Rotate(0, -90, 0);
        this.startPos = this.transform.position;
        this.startAng = this.transform.eulerAngles;
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
            this.bButton.SetActive(true); 
        }
    }
    public void DeskZoomCamera()
    {
        if (this.zoomState[1] == false)
        {
            this.zoomState[1] = true;
            this.MCamera.transform.Rotate(20, -45, 0);
            this.MCamera.transform.position = new Vector3(-5, 15, this.desk.transform.position.z);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);
            this.interPos = this.transform.position;
            this.interAng = this.transform.eulerAngles;
        }
       
    }
    public void OverDeskZoomCamera()
    {
        if (this.zoomState[1])
        {
            this.zoomState[2] = true;
            this.MCamera.transform.Rotate(10, 0, 0);
            this.MCamera.transform.position = new Vector3(-15, 20, this.desk.transform.position.z);
        }
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
        else if (this.zoomState[1] & this.zoomState[2] == false)
        {
            this.zoomState[1] = false;
            this.MCamera.transform.eulerAngles = this.startAng;
            this.MCamera.transform.position = this.startPos;
            this.rButton.SetActive(true);
            this.lButton.SetActive(true);
            this.bButton.SetActive(false);
        }
        else if (this.zoomState[2])
        {
            this.zoomState[2] = false;
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }
    }
}
