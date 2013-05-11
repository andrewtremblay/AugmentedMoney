using UnityEngine;
using System.Collections;

public class SimpleSpinScript : MonoBehaviour {
	public Vector3 rotateVert = new Vector3(0,1,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate(rotateVert);
	}
}
