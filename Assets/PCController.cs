using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCController : MonoBehaviour
{
    public InputField inputField;
    public Text underText;
    public GameObject inputFieldObject;
    public GameObject okButton;
    private int errorPoint = 0;
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
        if (this.inputField.text == "OPEN")
        {
         
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
}
