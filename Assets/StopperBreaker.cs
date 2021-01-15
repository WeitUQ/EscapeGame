using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopperBreaker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //スロットマシン内アイテムが受け皿に設置したコライダーと接触したとき
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Collider")
        {
            //0.5秒後にコライダーを破壊
            Destroy(other.gameObject, 0.5f);
        }
    }
}
