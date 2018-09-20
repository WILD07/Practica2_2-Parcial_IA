using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAControl : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent agenteDeNavegacion;
    public GameObject destino;
	// Use this for initialization
	void Start ()
    {
        agenteDeNavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agenteDeNavegacion.SetDestination(destino.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
