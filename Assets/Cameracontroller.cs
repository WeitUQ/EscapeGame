using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject desk;
    public GameObject[] boxCollider;
    public Collider deskCollider;
    public Collider bedCollider;
    public GameObject door;
    public GameObject pcCanvas;
    public GameObject pcCamera;
    public GameObject MCamera;   
    public Collider[] slotColliders;
    public GameObject rButton;
    public GameObject lButton;
    public GameObject bButton;
    public bool[] zoomState;
    private Vector3 startPos;
    private Vector3 startAng;
    private Vector3 interPos;
    private Vector3 interAng;
    // Start is called before the first frame update
    void Start()
    {
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
        if (this.zoomState[1] == false && this.zoomState[2] == false && this.zoomState[3] == false)
        {
            this.boxCollider[0].SetActive(true);
            this.boxCollider[1].SetActive(true);
            this.deskCollider.enabled = false;
            this.zoomState[1] = true;
            this.MCamera.transform.Rotate(20, -45, 0);
            this.MCamera.transform.position = new Vector3(-5, 20, this.desk.transform.position.z);
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
            this.zoomState[1] = false;
            this.zoomState[2] = true;
            this.boxCollider[1].SetActive(false);
            this.MCamera.transform.Rotate(35, 0, 0);
            this.MCamera.transform.position = new Vector3(-23, 25, this.desk.transform.position.z);
        }
    }
    public void DrawerZoomCamera()
    {
        if (this.zoomState[1])
        {
            this.boxCollider[0].SetActive(false);
            this.zoomState[1] = false;
            this.zoomState[3] = true;
            this.MCamera.transform.Rotate(33, 0, 0);
            this.MCamera.transform.position = new Vector3(-18, 16, this.desk.transform.position.z +7);
        }
    }
    public void SlotMachineZoomCamera()
    {
        if (this.zoomState[4] == false)
        {
            this.boxCollider[2].SetActive(false);
            this.zoomState[4] = true;
            this.MCamera.transform.Rotate(20, -45, 0);
            this.MCamera.transform.position = new Vector3(30, 20, -10);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);
            this.interPos = this.transform.position;
            this.interAng = this.transform.eulerAngles;
        }
    }
    public void RedZoomCamera()
    {
        if (this.zoomState[4])
        {
            this.slotColliders[0].enabled = false;
            this.boxCollider[4].SetActive(true);
            this.zoomState[4] = false;
            this.zoomState[5] = true;
            this.MCamera.transform.Rotate(0, 0, 0);
            this.MCamera.transform.position = new Vector3(35, 17, 5);
        }
    }
    public void BlueZoomCamera()
    {
        if (this.zoomState[4])
        {
            this.slotColliders[1].enabled = false;
            this.boxCollider[3].SetActive(true);
            this.zoomState[4] = false;
            this.zoomState[6] = true;
            this.MCamera.transform.Rotate(0, 0, 0);
            this.MCamera.transform.position = new Vector3(15, 17, 5);
        }
    }
    public void PCZoomCamera()
    {
        if (this.zoomState[2])
        {
            this.zoomState[2] = false;
            this.zoomState[7] = true;
            this.MCamera.SetActive(false);
            this.pcCanvas.SetActive(true);
            this.pcCamera.SetActive(true);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true); 
        }
    }
    public void BedZoomCamera()
    {
        if (this.zoomState[8] == false)
        {
            this.bedCollider.enabled = false;
            this.zoomState[8] = true;
            this.MCamera.transform.Rotate(20, -45, 0);
            this.MCamera.transform.position = new Vector3(0, 20, -50);
            this.rButton.SetActive(false);
            this.lButton.SetActive(false);
            this.bButton.SetActive(true);
            this.interPos = this.transform.position;
            this.interAng = this.transform.eulerAngles;
        }
    }
    public void OverBedZoomCamera()
    {
        if (this.zoomState[8])
        {
            this.zoomState[8] = false;
            this.zoomState[9] = true;
            this.boxCollider[5].SetActive(false);
            this.MCamera.transform.Rotate(20, 0, 0);
            this.MCamera.transform.position = new Vector3(15, 20, -50);
        }
    }
    public void UnderBedZoomCamera()
    {
        if (this.zoomState[8])
        {
            this.zoomState[8] = false;
            this.zoomState[10] = true;
            this.boxCollider[6].SetActive(false);
            this.MCamera.transform.Rotate(-20, 0, 0);
            this.MCamera.transform.position = new Vector3(25, 0.6f, -55);
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
        else if (this.zoomState[1])
        {
            this.boxCollider[0].SetActive(false);
            this.boxCollider[1].SetActive(false);
            this.zoomState[1] = false;
            this.MCamera.transform.eulerAngles = this.startAng;
            this.MCamera.transform.position = this.startPos;
            this.rButton.SetActive(true);
            this.lButton.SetActive(true);
            this.bButton.SetActive(false);
            this.deskCollider.enabled = true;
        }
        else if (this.zoomState[2])
        {
            this.boxCollider[1].SetActive(true);
            this.zoomState[1] = true;
            this.zoomState[2] = false;
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }
        else if (this.zoomState[3])
        {
            this.boxCollider[0].SetActive(true);
            this.zoomState[1] = true;
            this.zoomState[3] = false;
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }      
        else if (this.zoomState[4])
        {
            this.zoomState[4] = false;
            this.MCamera.transform.eulerAngles = this.startAng;
            this.MCamera.transform.position = this.startPos;
            this.rButton.SetActive(true);
            this.lButton.SetActive(true);
            this.bButton.SetActive(false);
            this.boxCollider[2].SetActive(true);
        }
        else if (this.zoomState[5])
        {
            this.slotColliders[0].enabled = true;
            this.zoomState[4] = true;
            this.zoomState[5] = false;
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }
        else if (this.zoomState[6])
        {
            this.slotColliders[1].enabled = true;
            this.zoomState[4] = true;
            this.zoomState[6] = false;
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }
        else if (this.zoomState[7])
        {
            this.zoomState[2] = true;
            this.zoomState[7] = false;
            this.pcCamera.SetActive(false);
            this.pcCanvas.SetActive(false);
            this.MCamera.SetActive(true);
        }
        else if (this.zoomState[8])
        {
            this.zoomState[8] = false;
            this.bedCollider.enabled = true;
            this.MCamera.transform.eulerAngles = this.startAng;
            this.MCamera.transform.position = this.startPos;
            this.rButton.SetActive(true);
            this.lButton.SetActive(true);
            this.bButton.SetActive(false);
        }
        else if (this.zoomState[9])
        {
            this.zoomState[8] = true;
            this.zoomState[9] = false;
            this.boxCollider[5].SetActive(true);
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }
        else if (this.zoomState[10])
        {
            this.zoomState[8] = true;
            this.zoomState[10] = false;
            this.boxCollider[6].SetActive(true);
            this.MCamera.transform.eulerAngles = this.interAng;
            this.MCamera.transform.position = this.interPos;
        }
    }
}
