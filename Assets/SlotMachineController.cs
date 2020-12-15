using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineController : MonoBehaviour
{
    public GameObject missPaper;
    public GameObject drawerKey;
    public GameObject[] items;
    public GameObject[] frames;
    public ItemController iScript;
    public Animator[] leverAnimator;
    public Animator[] reelAnimatorB;
    private int prob;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LeverONBlue()
    {
        this.leverAnimator[0].SetTrigger("ONBlue");
        if (this.iScript.bCoinCount == 3 )
        {
            this.iScript.bCoinCount = 0;
            this.reelAnimatorB[0].SetBool("RotationA", true);
            this.reelAnimatorB[1].SetBool("RotationB", true);
            this.reelAnimatorB[2].SetBool("RotationC", true); 
            this.reelAnimatorB[3].SetBool("RotationD", true);

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
