using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public GameObject textCamera;
    public GameObject zoomCamera;
    public ItemController iScript;
    public GameObject textCanvas;
    public GameObject bButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextChanger()
    {
        this.iScript.zoomList[0].SetActive(false);
        this.iScript.zoomList[1].SetActive(false);
        this.iScript.zoomList[2].SetActive(false);
        this.iScript.zoomList[3].SetActive(false);
        this.iScript.zoomList[4].SetActive(false);
        this.iScript.zoomList[5].SetActive(false);
        this.iScript.zoomList[6].SetActive(false);
        this.iScript.closeButton.SetActive(true);
        this.bButton.SetActive(true);
        this.zoomCamera.SetActive(false);
        this.textCamera.SetActive(false);
        this.textCanvas.SetActive(false);
    }
}
