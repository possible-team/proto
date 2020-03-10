using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    float x = 0.0f;
    float y = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var sprite = GetComponent<SpriteRenderer>();

        if (x < -sprite.size.x * transform.localScale.x)
        {
            x = sprite.size.x * transform.localScale.x;
        }

        x -= 0.01f;
        transform.position = new Vector2(x,y);
    }
}
