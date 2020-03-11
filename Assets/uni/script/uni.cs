using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uni : MonoBehaviour
{
    public int destroy_fream = 600;
    private int fream;
    // Start is called before the first frame update
    void Start()
    {
        fream = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (fream >= destroy_fream)
        {
            Destroy(gameObject);
        }
        fream++;
    }
}
