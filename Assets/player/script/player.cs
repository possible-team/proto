using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public KeyCode shoot = KeyCode.Space;
    public KeyCode angle_up = KeyCode.W;
    public KeyCode angle_down = KeyCode.S;

    public GameObject uni;
    private Vector2 angle = new Vector2(1.0f,0.0f);
    public float shoot_force = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        angle.Normalize();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(angle_up) && angle.y<0.8f)
        {
            angle.y += 0.01f;
        }
        if (Input.GetKey(angle_down) && angle.y > -0.8f)
        {
            angle.y -= 0.01f;
        }

        angle.Normalize();

        if (Input.GetKeyDown(shoot))
        {
            GameObject unis = Instantiate(uni);
            Rigidbody2D rigi = unis.GetComponent<Rigidbody2D>();
            rigi.AddForce(angle * shoot_force);
            unis.transform.position = transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bubble"))
        {
            var w = transform.position;
            w.x -= 0.5f;
            transform.position = w;
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
