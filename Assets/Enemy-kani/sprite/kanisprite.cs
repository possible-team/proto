using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kanisprite : MonoBehaviour
{
    int ctime;  //生成してからの時間
    int interval = 80;   //生成の間隔

    public GameObject bubble;
    int move = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スタートするタイミングをカウント
        move += 1;

        if (move > 1200 && move < 2100)
        { 
            Vector3 m_pos = transform.localPosition;
            m_pos.x += -0.02f;
            transform.localPosition = m_pos;  // 移動を更新
        }

        //泡生成の処理
        //ctimeに経過時間を加算
        ctime++;
        if (ctime >= interval)
        {
            //InstantiateでGameObject生成
            //Instantiate(複製するGameObject,位置,回転)の順番で記載
            GameObject bubles = Instantiate(bubble);
            bubles.transform.position = transform.position;

            //ctimeを0に戻す
            ctime = 0;
        }


    }


}
