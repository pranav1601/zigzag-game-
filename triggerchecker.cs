using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerchecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerChecker(Collider col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Invoke("falldown", 0.5f);
        
        }

    }
    void falldown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.parent.gameObject, 2f);
    }
}
