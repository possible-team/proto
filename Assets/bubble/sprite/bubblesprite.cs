using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblesprite : MonoBehaviour
{
   
    int destroy =1200;    //泡が消えるフレーム
    int fream = 0;  //泡が出現してからのフレーム

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //座標移動の処理
        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
        pos.x += -0.01f;    // x座標へ加算
        pos.y += 0.00f;    // y座標へ加算
        pos.z += 0.00f;    // z座標へ加算

        myTransform.position = pos;  // 座標を設定



        //消える処理
        fream++;
        if (fream >= destroy)
        {
            Destroy(this.gameObject);
            fream = 0;
        }
    }
}
