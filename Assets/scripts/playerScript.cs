using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class playerScript : MonoBehaviour {

	public GameObject player;
	//public GameObject[] attachedBody;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.W)) {
			//transform.Rotate(0f,1, 0f);
			player.transform.position += new Vector3 (0, 0, speed) * Time.deltaTime;
			player.transform.eulerAngles = new Vector3 (0, -180, 0);
		}
		else if (Input.GetKey (KeyCode.S)) {
			//transform.Rotate(0f,-1, 0f);
			player.transform.position += new Vector3 (0, 0, -speed) * Time.deltaTime;
			player.transform.eulerAngles = new Vector3 (0, 0, 0);

		}
		else if (Input.GetKey (KeyCode.A)) {
			//transform.Rotate(-1f,0, 0f);
			player.transform.position += new Vector3 (-speed, 0, 0) * Time.deltaTime;
			player.transform.eulerAngles = new Vector3 (0, 90, 0);

		}
		else if (Input.GetKey (KeyCode.D)) {
			//transform.Rotate(1f,0, 0f);
			player.transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;
			player.transform.eulerAngles = new Vector3 (0, -90, 0);

		}
		Camera.main.transform.position = transform.position + new Vector3 (0, 2, -4);
	}
}
