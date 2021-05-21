using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite[] sprite; //アイテムリストの枠画像
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

    //アイテムリストクリック時の処理
    public void SpriteChange()
    {
        //クリックされたリストの枠色を赤色にする
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
        this.itemList[11].GetComponent<Image>().sprite = this.sprite[0];
        if (this.iScript.chooseDrawerKey)
        {
            this.itemList[1].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseCoin)
        {
            this.itemList[2].GetComponent<Image>().sprite = this.sprite[1];
        }
        if(this.iScript.chooseHammer)
        {          
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseLight)
        {
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[1];
        } 
        else if (this.iScript.chooseIOU)
        {
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseAgreement)
        {
            this.itemList[6].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseContract)
        {
            this.itemList[7].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseCrushedNob)
        {
            this.itemList[8].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseDriver)
        {
            this.itemList[9].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseNob)
        {
            this.itemList[10].GetComponent<Image>().sprite = this.sprite[1];
        }
        else if (this.iScript.chooseKey)
        {
            this.itemList[11].GetComponent<Image>().sprite = this.sprite[1];
        }

    }
}
