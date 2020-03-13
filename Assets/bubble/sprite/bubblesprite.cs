using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblesprite : MonoBehaviour
{
    int ctime;  //生成してからの時間
    int interval = 300;   //生成の間隔

    int destroy =600;    //泡が消えるフレーム
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


        //生成の処理
        //ctimeに経過時間を加算
        ctime ++;
        if (ctime  >= interval)
        {
            //InstantiateでGameObject生成
            //Instantiate(複製するGameObject,位置,回転)の順番で記載
            Instantiate(this, new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), Random.Range(-1.0f, 1.0f)), Quaternion.identity);
            //ctimeを0に戻す
            ctime = 0;
        }


        //消える処理
        fream++;
        if (fream >= destroy)
        {
            Destroy(this.gameObject);
            fream = 0;
        }
    }
}
