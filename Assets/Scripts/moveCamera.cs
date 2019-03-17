using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

	public float speed;
	public Transform cameraMount;
	public AudioSource woosh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, cameraMount.position, speed);
		transform.rotation = Quaternion.Slerp (transform.rotation, cameraMount.rotation, speed);
	}

	public void setMount(Transform newMount){
		//woosh.Play();
		cameraMount = newMount;
	}

}
