using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplicatorAction : MonoBehaviour {

    public Material lights;
    Color fullbright = new Color(0, 0.8784313f, 1);
    Color nobright = new Color(0,0,0);
    float timestart;

    void Start()
    {
        lights.SetColor("_EmissionColor", nobright);
    }
    void Update () {
		
	}

    void ReplicateAnimationStart()
    {
        float t = (Time.time - timestart) * 0.1f;
        lights.SetColor("_EmissionColor", Color.Lerp(nobright, fullbright, t ));
        print("Bob Vladimir");
    }

    void ReplicateAnimationStop()
    {

    }

    public void ReplicateSphere()
    {
        ReplicateAnimationStart();

    }
}
