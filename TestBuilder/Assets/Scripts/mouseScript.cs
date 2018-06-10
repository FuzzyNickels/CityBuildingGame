using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseScript : MonoBehaviour {

	Vector3 lastFramePosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 curFramePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Screen drag
        if(Input.GetMouseButton(0)) {
            Vector3 diff = lastFramePosition - curFramePosition;
            Camera.main.transform.Translate(diff);
        }

        lastFramePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
}
