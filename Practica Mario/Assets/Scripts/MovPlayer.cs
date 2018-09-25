using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {
    
    public float jumpPower = 6.5f;
    private Rigidbody rb;
    private bool jump;
    public float speed = 10.0F; //Velocidad de movimiento
    //public float rotationSpeed = 100.0F; //Velocidad de rotación
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
        //transform.Rotate(0, Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = true;
        }
        if (jump)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpPower, ForceMode.Impulse);
            jump = false;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            //Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
