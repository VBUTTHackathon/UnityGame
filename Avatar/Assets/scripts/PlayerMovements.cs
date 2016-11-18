using UnityEngine;
using System.Collections;

public class PlayerMovements : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
			
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 mvm_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		if (mvm_vector != Vector2.zero) {
			anim.SetBool ("iswalking", true);
			anim.SetFloat ("input_x", mvm_vector.x);
			anim.SetFloat ("input_y", mvm_vector.y);
		} else {
			anim.SetBool ("iswalking", false);
		}

		rbody.MovePosition (rbody.position + mvm_vector * Time.deltaTime);
	}
}
