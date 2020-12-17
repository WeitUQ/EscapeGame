using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineController : MonoBehaviour
{
    public GameObject missPaper;
    public GameObject drawerKey;
    public GameObject[] items;
    public GameObject[] blueReels;
    public ItemController iScript;
    public Animator[] leverAnimator;
    private Vector3 blueStartPos1;
    private Vector3 blueStartPos2;
    private Vector3 blueStartPos3;
    private float blueRotSpeed = -0.005f;
    private int prob;
    private bool blueRotState = false;
    // Start is called before the first frame update
    void Start()
    {
        this.blueStartPos1 = this.blueReels[1].transform.position;
        this.blueStartPos2 = this.blueReels[3].transform.position;
        this.blueStartPos3 = this.blueReels[5].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.blueRotState)
        {
            this.blueReels[0].transform.Translate(0, this.blueRotSpeed, 0);
            this.blueReels[1].transform.Translate(0, this.blueRotSpeed, 0);
            this.blueReels[2].transform.Translate(0, this.blueRotSpeed, 0);
            this.blueReels[3].transform.Translate(0, this.blueRotSpeed, 0);
            this.blueReels[4].transform.Translate(0, this.blueRotSpeed, 0);
            this.blueReels[5].transform.Translate(0, this.blueRotSpeed, 0);
            if (this.blueReels[0].transform.position.y <= 7.3f)
            {
                this.blueReels[0].transform.position = blueStartPos1;
            }
            if (this.blueReels[1].transform.position.y <= 7.3f)
            {
                this.blueReels[1].transform.position = blueStartPos1;
            }
            if (this.blueReels[2].transform.position.y <= 7.3f)
            {
                this.blueReels[2].transform.position = blueStartPos2;
            }
            if (this.blueReels[3].transform.position.y <= 7.3f)
            {
                this.blueReels[3].transform.position = blueStartPos2;
            }
            if (this.blueReels[4].transform.position.y <= 7.3f)
            {
                this.blueReels[4].transform.position = blueStartPos3;
            }
            if (this.blueReels[5].transform.position.y <= 7.3f)
            {
                this.blueReels[5].transform.position = blueStartPos3;
            }
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
            this.prob = Random.Range(0, 100);
            if (this.prob >= 0 & this.prob <= 19)
            {
                this.drawerKey.SetActive(true);
            }
            else
            {
                this.missPaper.SetActive(true);
            }
        }
    }
}
