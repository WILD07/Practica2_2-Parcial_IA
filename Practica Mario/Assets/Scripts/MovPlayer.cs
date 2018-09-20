using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {

    public float speed = 10.0F; //Velocidad de movimiento
    //public float rotationSpeed = 100.0F; //Velocidad de rotación

    void Update()
    {
        transform.Translate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
        //transform.Rotate(0, Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime, 0);
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
