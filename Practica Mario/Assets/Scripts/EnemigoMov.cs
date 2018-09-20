using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoMov : MonoBehaviour {

    Transform player;

    NavMeshAgent nav;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //player = GameObject.Find("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(player.position);
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }        

    }
}
