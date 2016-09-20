using UnityEngine;
using System.Collections;

public class bodyScript : MonoBehaviour {
	public GameObject[] torso;
	public Vector3 rotateAmount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.Rotate(0, 1, 0);
//			for (int i = 0; i < torso.Length; i++) {
//				torso [i].transform.Rotate (rotateAmount.x, rotateAmount.y, rotateAmount.z);
//			}
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			rotateAmount = new Vector3 (0, -1, 0);
//			for (int i = 0; i < torso.Length; i++) {
				//torso [i].transform.localEulerAngles = transform.eulerAngles;
//				torso [i].transform.Rotate (rotateAmount.x, rotateAmount.y, rotateAmount.z);
//			}
		}
		else if (Input.GetKeyDown (KeyCode.A)) {
			transform.Rotate(-1, 0, 0);
//			for (int i = 0; i < torso.Length; i++) {
//				//torso [i].transform.localEulerAngles = transform.eulerAngles;
//				torso [i].transform.Rotate (rotateAmount.x, rotateAmount.y, rotateAmount.z);
//			}
		}
		else if (Input.GetKeyDown (KeyCode.D)) {
			transform.Rotate(1, 0, 0);
//			for (int i = 0; i < torso.Length; i++) {
//				//torso [i].transform.localEulerAngles = transform.eulerAngles;
//				torso [i].transform.Rotate (rotateAmount.x, rotateAmount.y, rotateAmount.z);
//			}
		}
	}
}
