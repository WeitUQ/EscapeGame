using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineController : MonoBehaviour
{
    public GameObject missPaper;
    public GameObject drawerKey;
    public GameObject[] items;
    public GameObject[] blueMainReels;
    public GameObject[] blueSubReels;
    public GameObject[] redMainReels;
    public GameObject[] redSubReels;
    public GameObject[] blueStopColliders;
    public GameObject[] redStopColliders;
    public CameraController cScript;
    public ItemController iScript;
    public Animator[] leverAnimator;
    public float[] blueRotSpeed;
    public float[] redRotSpeed;
    private bool blueRotState = false;
    private bool redRotState = false;
    public bool[] blueRotStop = { false, false, false };
    public bool[] redRotStop = { false, false, false };
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (this.blueRotState)
        {
            this.blueMainReels[0].transform.Translate(0, this.blueRotSpeed[0] * Time.deltaTime, 0);
            this.blueMainReels[1].transform.Translate(0, this.blueRotSpeed[1] * Time.deltaTime, 0);
            this.blueMainReels[2].transform.Translate(0, this.blueRotSpeed[2] * Time.deltaTime, 0);
            if (this.blueSubReels[0].transform.position.y <= 7.9f)
            {
                this.blueSubReels[0].transform.position = new Vector3(12.8f, this.blueSubReels[1].transform.position.y + 10.2f, this.blueSubReels[0].transform.position.z);
            }
            if (this.blueSubReels[1].transform.position.y <= 7.9f)
            {
                this.blueSubReels[1].transform.position = new Vector3(12.8f, this.blueSubReels[0].transform.position.y + 10.2f, this.blueSubReels[1].transform.position.z);
            }
            if (this.blueSubReels[2].transform.position.y <= 7.9f)
            {
                this.blueSubReels[2].transform.position = new Vector3(15.6f, this.blueSubReels[3].transform.position.y + 10.2f, this.blueSubReels[2].transform.position.z); 
            }
            if (this.blueSubReels[3].transform.position.y <= 7.9f)
            {
                this.blueSubReels[3].transform.position = new Vector3(15.6f, this.blueSubReels[2].transform.position.y + 10.2f, this.blueSubReels[3].transform.position.z);
            }
            if (this.blueSubReels[4].transform.position.y <= 7.9f)
            {
                this.blueSubReels[4].transform.position = new Vector3(18.4f, this.blueSubReels[5].transform.position.y + 10.2f, this.blueSubReels[4].transform.position.z);
            }
            if (this.blueSubReels[5].transform.position.y <= 7.9f)
            {
                this.blueSubReels[5].transform.position = new Vector3(18.4f, this.blueSubReels[4].transform.position.y + 10.2f, this.blueSubReels[5].transform.position.z);
            }
        }
        
        if (this.redRotState)
        {
            this.redMainReels[0].transform.Translate(0, this.redRotSpeed[0] * Time.deltaTime, 0);
            this.redMainReels[1].transform.Translate(0, this.redRotSpeed[1] * Time.deltaTime, 0);
            this.redMainReels[2].transform.Translate(0, this.redRotSpeed[2] * Time.deltaTime, 0);
            if (this.redSubReels[0].transform.position.y <= 7.9f)
            {
                this.redSubReels[0].transform.position = new Vector3(32.35f, this.redSubReels[1].transform.position.y + 10.2f, this.redSubReels[0].transform.position.z);
            }
            if (this.redSubReels[1].transform.position.y <= 7.9f)
            {
                this.redSubReels[1].transform.position = new Vector3(32.35f, this.redSubReels[0].transform.position.y + 10.2f, this.redSubReels[1].transform.position.z);
            }
            if (this.redSubReels[2].transform.position.y <= 7.9f)
            {
                this.redSubReels[2].transform.position = new Vector3(35.15f, this.redSubReels[3].transform.position.y + 10.2f, this.redSubReels[2].transform.position.z);
            }
            if (this.redSubReels[3].transform.position.y <= 7.9f)
            {
                this.redSubReels[3].transform.position = new Vector3(35.15f, this.redSubReels[2].transform.position.y + 10.2f, this.redSubReels[3].transform.position.z);
            }
            if (this.redSubReels[4].transform.position.y <= 7.9f)
            {
                this.redSubReels[4].transform.position = new Vector3(37.95f, this.redSubReels[5].transform.position.y + 10.2f, this.redSubReels[4].transform.position.z);
            }
            if (this.redSubReels[5].transform.position.y <= 7.9f)
            {
                this.redSubReels[5].transform.position = new Vector3(37.95f, this.redSubReels[4].transform.position.y + 10.2f, this.redSubReels[5].transform.position.z);
            }
        }
    }
    public void LeverONBlue()
    {
        if (this.cScript.zoomState[6])
        {
            this.leverAnimator[0].SetTrigger("ONBlue");
            if (this.iScript.bCoinCount == 3)
            {
                this.iScript.bCoinCount = 0;
                this.blueRotState = true;
            }
        }
    }
    public void LeverONRed()
    {
        if (this.cScript.zoomState[5])
        {
            this.leverAnimator[1].SetTrigger("ONRed");
            if (this.iScript.rCoinCount == 3)
            {
                this.iScript.rCoinCount = 0;
                this.redRotState = true;
            }
        }
    }
    public void StopReelBlue1()
    {
        if (this.cScript.zoomState[6] && this.blueRotSpeed[0] == -1.0f && this.blueRotState)
        {
           
            this.blueRotStop[0] = true;
            this.blueStopColliders[0].SetActive(true);
        }
    }
    public void StopReelBlue2()
    {
        if (this.cScript.zoomState[6] && this.blueRotSpeed[1] == -1.0f && this.blueRotState)
        {
          
            this.blueRotStop[1] = true;
            this.blueStopColliders[1].SetActive(true);
        }
    }
    public void StopReelBlue3()
    {
        if (this.cScript.zoomState[6] && this.blueRotSpeed[2] == -1.0f && this.blueRotState)
        {
          
            this.blueRotStop[2] = true;
            this.blueStopColliders[2].SetActive(true);
        }
    }
    public void StopReelRed1()
    {
        if (this.cScript.zoomState[5] && this.redRotSpeed[0] == -10.0f && this.redRotState)
        {
            this.redRotStop[0] = true;
            this.redStopColliders[0].SetActive(true);
        }
    }
    public void StopReelRed2()
    {
        if (this.cScript.zoomState[5] && this.redRotSpeed[1] == -10.0f && this.redRotState)
        {
            this.redRotStop[1] = true;
            this.redStopColliders[1].SetActive(true);
        }
    }
    public void StopReelRed3()
    {
        if (this.cScript.zoomState[5] && this.redRotSpeed[2] == -10.0f && this.redRotState)
        {
            this.redRotStop[2] = true;
            this.redStopColliders[2].SetActive(true);
        }
    }
}
