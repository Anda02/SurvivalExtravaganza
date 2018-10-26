using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRaycast : MonoBehaviour {

    GameObject currenthit;
    //Script is for generating a raycast from the camera in order to interact with various objects in the scene.
	void Start () {
		
	}
	
    
	void Update ()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            RaycastHit hit;

            if (Physics.Raycast(transform.position, fwd, out hit, 10))
            {
                currenthit = hit.transform.gameObject;
                print(hit.transform.gameObject.name);
            }
        }
        
    }
}
