using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //doorを開けるアニメーション
    public Animator doorOpen;

    //ドアを開けるフラグ
    public bool lockState = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ドアにカギ使用後にドアをクリックしたときの処理
    public void OpenDoor()
    {
        //ドアを開けるアニメーションを実行
        if(this.lockState)
        this.doorOpen.SetTrigger("Open");
    }
}
