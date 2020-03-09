using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_two : MonoBehaviour
{
    float x = 25.0f;
    float y = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x < -25)
        {
            x = 25.0f;
        }
        x -= 0.01f;
        transform.position = new Vector2(x, y);
    }
}
