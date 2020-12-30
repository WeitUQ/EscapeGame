using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite[] sprite;
    public GameObject[] itemList;
    public ItemController iScript;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpriteChange()
    {
        if (this.iScript.chooseDrawerKey)
        {
            this.itemList[0].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[0];
        }
        if(this.iScript.chooseHammer)
        {
            this.itemList[0].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[0];
        }
        else if (this.iScript.chooseNob)
        {
            this.itemList[0].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[0];
        }
        else if (this.iScript.chooseKey)
        {
            this.itemList[0].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseCoin)
        {
            this.itemList[0].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[0];
        }
        else if (this.iScript.chooseDriver)
        {
            this.itemList[0].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[0];
        }
    }
}
