using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public KeyCode shoot = KeyCode.Space;
    public GameObject uni;
    public Vector2 angle = new Vector2(1.0f,0.0f);
    public float shoot_force = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        angle.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(shoot))
        {
            GameObject unis = Instantiate(uni);
            Rigidbody2D rigi = unis.GetComponent<Rigidbody2D>();
            rigi.AddForce(angle * shoot_force);
            unis.transform.position = transform.position;
        }
    }
}
