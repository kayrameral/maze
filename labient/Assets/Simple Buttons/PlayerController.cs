using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 1.5f;
    public float Jumpforce = 0.00003f;
    private Rigidbody rb = null;
    private bool onGround = true;
    void Start()
    {
        speed = 1.5f;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f,
            speed * Input.GetAxis("Horizontal") * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) == true && onGround == true)
        {
            onGround = false;
            rb.AddForce(Vector3.up * Jumpforce, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}