using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRaycast : MonoBehaviour {

    //Script is for generating a raycast from the camera in order to interact with various objects in the scene.
	void Start () {
		
	}
	
    
	public void OnPointerDown(PointerEventData evdata)
    {
        print(evdata.pointerPress);
    }
}
