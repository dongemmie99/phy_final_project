using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	float speed = 1.0f;
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.D)) {
			animator.SetInteger ("AnimState", 1);
			transform.position += Vector3.right * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.A)) {
			animator.SetInteger ("AnimState", 2);
			transform.position += Vector3.left * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.S)) { 
			animator.SetInteger ("AnimState", 3);
			transform.position += Vector3.down * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.W)) { 
			animator.SetInteger ("AnimState", 3);
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		else {
			animator.SetInteger ("AnimState", 0);
		}

	}
}
