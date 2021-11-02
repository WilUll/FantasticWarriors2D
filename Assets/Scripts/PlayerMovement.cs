using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    Rigidbody2D rb2D;

    Transform Flashlight;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        Flashlight = GameObject.FindGameObjectWithTag("Flashlight").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(x, y).normalized * speed;

        rb2D.velocity = movement;

        Debug.Log(Input.mousePosition);

        //Flashlight.Rotate(0, 0, mousePos);
    }
}
