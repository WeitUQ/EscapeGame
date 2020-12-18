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
    public ItemController iScript;
    public Animator[] leverAnimator;
    private Vector3 blueStartPos1;
    private Vector3 blueStartPos2;
    private Vector3 blueStartPos3;
    private float[] blueRotSpeed = { -0.005f, -0.005f, -0.005f };
    private int prob;
    private bool blueRotState = false;
    private bool[] blueRotStop = { false, false, false };
    // Start is called before the first frame update
    void Start()
    {
        this.blueStartPos1 = this.blueSubReels[1].transform.position;
        this.blueStartPos2 = this.blueSubReels[3].transform.position;
        this.blueStartPos3 = this.blueSubReels[5].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.blueRotState)
        {
            this.blueMainReels[0].transform.Translate(0, this.blueRotSpeed[0], 0);
            this.blueMainReels[1].transform.Translate(0, this.blueRotSpeed[1], 0);
            this.blueMainReels[2].transform.Translate(0, this.blueRotSpeed[2], 0);
            if (this.blueSubReels[0].transform.position.y <= 7.3f)
            {
                this.blueSubReels[0].transform.position = blueStartPos1;
            }
            if (this.blueSubReels[1].transform.position.y <= 7.3f)
            {
                this.blueSubReels[1].transform.position = blueStartPos1;
            }
            if (this.blueSubReels[2].transform.position.y <= 7.3f)
            {
                this.blueSubReels[2].transform.position = blueStartPos2;
            }
            if (this.blueSubReels[3].transform.position.y <= 7.3f)
            {
                this.blueSubReels[3].transform.position = blueStartPos2;
            }
            if (this.blueSubReels[4].transform.position.y <= 7.3f)
            {
                this.blueSubReels[4].transform.position = blueStartPos3;
            }
            if (this.blueSubReels[5].transform.position.y <= 7.3f)
            {
                this.blueSubReels[5].transform.position = blueStartPos3;
            }
        }
        if (this.blueRotStop[0] && Mathf.Abs(this.blueMainReels[0].transform.position.y % 1.7f) > 0.38f && Mathf.Abs(this.blueMainReels[0].transform.position.y % 1.7f) < 0.42f)
        {
            this.blueRotSpeed[0] = 0;
        }
        if (this.blueRotStop[1] && Mathf.Abs(this.blueMainReels[1].transform.position.y % 1.7f) > 0.38f && Mathf.Abs(this.blueMainReels[1].transform.position.y % 1.7f) < 0.42f)
        {
            this.blueRotSpeed[1] = 0;
        }
        if (this.blueRotStop[2] && Mathf.Abs(this.blueMainReels[2].transform.position.y % 1.7f) > 0.38f && Mathf.Abs(this.blueMainReels[2].transform.position.y % 1.7f) < 0.42f)
        {
            this.blueRotSpeed[2] = 0;
        }
    }
    public void LeverONBlue()
    {
        this.leverAnimator[0].SetTrigger("ONBlue");
        if (this.iScript.bCoinCount == 3 )
        {
            this.iScript.bCoinCount = 0;
            this.blueRotState = true;
        }
    }
    public void LeverONRed()
    {
        this.leverAnimator[1].SetTrigger("ONRed");
    }
    public void RedMachineController()
    {
        if (this.iScript.rCoinCount == 3)
        {
            this.iScript.rCoinCount = 0;
           
        }
    }
    public void StopReelBlue1()
    {
        if (this.blueRotSpeed[0] != 0)
        {
            this.blueRotSpeed[0] = -0.002f;
            this.blueRotStop[0] = true;
        }
    }
    public void StopReelBlue2()
    {
        if (this.blueRotSpeed[1] != 0)
        {
            this.blueRotSpeed[1] = -0.002f;
            this.blueRotStop[1] = true;
        }
    }
    public void StopReelBlue3()
    {
        if (this.blueRotSpeed[2] != 0)
        {
            this.blueRotSpeed[2] = -0.002f;
            this.blueRotStop[2] = true;
        }
    }
}
