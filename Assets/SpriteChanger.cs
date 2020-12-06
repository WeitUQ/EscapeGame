using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite[] sprite;
    public GameObject[] itemList;
    private GameObject iController;
    private ItemController script;
    // Start is called before the first frame update
    void Start()
    {
        this.iController = GameObject.Find("ItemController");
        this.script = iController.GetComponent<ItemController>();
        this.itemList = GameObject.FindGameObjectsWithTag("ItemList");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpriteChange()
    {
        if(this.script.chooseHammer)
        {
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
        }
        else if (this.script.chooseNob)
        {
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[1];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[0];
        }
        else if (this.script.chooseKey)
        {
            this.itemList[3].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[4].GetComponent<Image>().sprite = this.sprite[0];
            this.itemList[5].GetComponent<Image>().sprite = this.sprite[1];
        }
    }
}
