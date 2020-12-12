using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineController : MonoBehaviour
{
    public GameObject missPaper;
    public GameObject drawerKey;
    public GameObject[] items;
    public ItemController iScript;
    private int prob;
    // Start is called before the first frame update
    void Start()
    {
        this.drawerKey.SetActive(false);
        this.missPaper.SetActive(false);
        this.items[0].SetActive(false);
        this.items[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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
    public void BlueMachineController()
    {
        if (this.iScript.bCoinCount == 3)
        {
            this.iScript.bCoinCount = 0;
            this.prob = Random.Range(0, 100);
            if (this.prob >= 0 & this.prob <= 49)
            {
                this.items[0].SetActive(true);
            }
            else
            {
                this.items[1].SetActive(true);
            }
        }
    }
}
