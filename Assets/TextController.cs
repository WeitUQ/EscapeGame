using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public GameObject textCamera;
    public GameObject zoomCamera;
    public ItemController iScript;
    public GameObject textCanvas;
    public GameObject bButton;
    public Text text;
    public string[] IOUScenerios;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //テキストウィンドウクリック時の処理
    public void TextChanger()
    {
        if (this.iScript.zoomList[9].activeSelf && i <= 4)
        {
            this.text.text = this.IOUScenerios[i];
            i++;
        }
        else
        {
            this.iScript.zoomList[0].SetActive(false);
            this.iScript.zoomList[1].SetActive(false);
            this.iScript.zoomList[2].SetActive(false);
            this.iScript.zoomList[3].SetActive(false);
            this.iScript.zoomList[4].SetActive(false);
            this.iScript.zoomList[5].SetActive(false);
            this.iScript.zoomList[6].SetActive(false);
            this.iScript.zoomList[7].SetActive(false);
            this.iScript.zoomList[8].SetActive(false);
            this.iScript.zoomList[9].SetActive(false);
            this.iScript.zoomList[10].SetActive(false);
            this.iScript.zoomList[11].SetActive(false);
            this.iScript.closeButton.SetActive(true);
            this.text.text = null;
            this.bButton.SetActive(true);
            this.zoomCamera.SetActive(false);
            this.textCamera.SetActive(false);
            this.textCanvas.SetActive(false);
        }
    }
}
