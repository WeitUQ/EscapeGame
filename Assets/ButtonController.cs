using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Sprite[] lineSprite;
    private Image lineImage;
    // Start is called before the first frame update
    void Start()
    {
       this.lineImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LineColor()
    {
        this.lineImage.sprite = this.lineSprite[1];
       
    }

}
