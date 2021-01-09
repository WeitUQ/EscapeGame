using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCController : MonoBehaviour
{
    public InputField inputField;
    public Text underText;
    public GameObject image;
    public GameObject waitTextObject;
    public GameObject inputFieldObject;
    public GameObject okButton;
    public GameObject[] folders;
    private int errorPoint = 0;
    private bool singleClick = false;
    public float[] clickTimes = { 0f, 0f };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterON()
    {
        if (this.inputField.text == "open")
        {
            Destroy(this.inputFieldObject);
            Destroy(this.underText);
            this.waitTextObject.SetActive(true);
            Invoke("ScreenChange", 0.5f);
        }
        else
        {
            this.inputFieldObject.SetActive(false);
            this.errorPoint++;
            this.underText.text = "パスワードが正しくありません。入力し直してください。";
            this.okButton.SetActive(true);            
        }
    }
    public void OKON()
    {
        this.inputFieldObject.SetActive(true);
        this.okButton.SetActive(false);
        this.underText.text = null;
        if(this.errorPoint >= 3)
            {
                this.underText.text = "パスワードのヒント: 閉じる = close, 開ける = ????";
            }
    }
    private void ScreenChange()
    {
        Destroy(this.waitTextObject);
        this.image.SetActive(true);
        this.folders[0].SetActive(true);
    }
    public void FolderOpen()
    {
        if (this.singleClick)
        {
            this.clickTimes[1] = Time.time;
            if (this.clickTimes[1] - this.clickTimes[0] < 0.4f)
            {
                Debug.Log("OK");
            }
            else
            {
                this.clickTimes[0] = this.clickTimes[1];
                this.clickTimes[1] = 0;
            }
        }         
        else if (this.singleClick == false)
        {
            this.singleClick = true;
            this.clickTimes[0] = Time.time;
        }
        
    }
}
