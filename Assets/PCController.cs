using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCController : MonoBehaviour
{
    public InputField inputField;
    public Text underText;
    public GameObject okButton;
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
            this.underText.text = "パスワードが正しくありません。入力し直してください。";
            this.okButton.SetActive(true);
        }
    }
    public void OKON()
    {
        this.okButton.SetActive(false);
        this.underText.text = null;
    }
}
