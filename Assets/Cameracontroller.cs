using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cameracontroller : MonoBehaviour
{
    private bool isRButton = false;
    private bool isLButton = false;
    private GameObject MCamera;
    // Start is called before the first frame update
    void Start()
    {
        this.MCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
       if (this.isRButton)
        {
            this.MCamera.transform.Rotate(0, 90, 0);
            this.isRButton = false;
        }
        else if (this.isLButton)
        {
            this.MCamera.transform.Rotate(0, -90, 0);
            this.isLButton = false;
        }
    }
    public void RAngleChange()
    {
        this.isRButton = true;
    }
    public void LAngleChange()
    {
        this.isLButton = true;
    }
}
