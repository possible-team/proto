using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_two : MonoBehaviour
{
    float x = 0.0f;
    float y = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        x = GetComponent<SpriteRenderer>().size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        var sprite = GetComponent<SpriteRenderer>();

        //右の端の位置まで戻る
        if (x < -sprite.size.x * transform.localScale.x )
        {
            x = sprite.size.x * transform.localScale.x;
        }

        x -= 0.01f;
        transform.position = new Vector2(x, y);
    }
}
