using UnityEngine;
using System.Collections;

public class buttonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.eulerAngles = new Vector3 (0, 1, 0);
		}
		else if (Input.GetKey (KeyCode.S)) {
			transform.eulerAngles = new Vector3 (0, -1, 0);
		}
		else if (Input.GetKey (KeyCode.A)) {
			transform.eulerAngles = new Vector3 (-1, 0, 0);
		}
		else if (Input.GetKey (KeyCode.D)) {
			transform.eulerAngles = new Vector3 (1, 0, 0);
		}
	}
}
