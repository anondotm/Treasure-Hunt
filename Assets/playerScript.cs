using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0, 0, speed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 0, 1);
		}
		else if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -speed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 0, -1);
		}
		else if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-speed, 0, 0) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (-1, 0, 0);
		}
		else if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (1, 0, 0);
		}
		Camera.main.transform.position = transform.position + new Vector3 (0, 2, -4);
	}
}
