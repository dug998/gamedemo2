using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D myBody;
    public float maxSpeed;
    // Start is called before the first frame update
    private void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        myBody.velocity = new Vector2(x * maxSpeed, myBody.velocity.y);
    }
}
