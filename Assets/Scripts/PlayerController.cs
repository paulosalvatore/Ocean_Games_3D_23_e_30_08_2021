using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed = 1f;

    public GameObject vitoriaText;

    public GameObject derrotaText;

    void Update()
    {
        var v = Input.GetAxis("Vertical") * moveSpeed;
        var h = Input.GetAxis("Horizontal") * moveSpeed;

        rb.velocity = new Vector3(h, rb.velocity.y, v);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vitoria"))
        {
            vitoriaText.SetActive(true);
        }
    }
}
