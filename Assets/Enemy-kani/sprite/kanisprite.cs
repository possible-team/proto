using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kanisprite : MonoBehaviour
{
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
    }
}
