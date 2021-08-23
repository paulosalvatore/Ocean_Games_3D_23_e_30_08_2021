using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical") * moveSpeed;
        var h = Input.GetAxis("Horizontal") * moveSpeed;

        rb.velocity = new Vector3(h, rb.velocity.y, v);
    }
}
