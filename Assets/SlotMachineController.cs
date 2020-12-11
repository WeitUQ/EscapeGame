using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineController : MonoBehaviour
{
    public GameObject drawerKey;
    public ItemController iScript;
    private int prob;
    // Start is called before the first frame update
    void Start()
    {
        this.drawerKey.SetActive(false);
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

            }
        }
    }
    public void BlueMachineController()
    {

    }
}
