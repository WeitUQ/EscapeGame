using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotItemSlider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //スロットマシン内アイテムがスロープに設置されたコライダーに接触したときの処理
    private void OnCollisionEnter(Collision other)
    {
        //アイテムのリジッドボディ設定を変更
        other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
