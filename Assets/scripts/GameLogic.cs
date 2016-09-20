using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {
	bool didPlayerWin = false;
	public GameObject locator;
	public GameObject playerLocator;
	public GameObject controlPrompt;
	public Text textObject;
	public string[] treasureString; //array of messages for "textObject"
	public Transform player;
	public Transform treasureActive;
	public Transform[] treasureArray; //array of treasure Transforms
	public int counter; //counter variable
	// Use this for initialization
	void Start () {
		counter = 0;
		treasureActive = treasureArray [counter];
	}
	
	// Update is called once per frame
	void Update () {


		if (didPlayerWin) {
			textObject.text = "You found your ship! Press 'SPACE' to return to your mission.";
		} else if ((player.position - treasureActive.position).magnitude < 5f) {
			controlPrompt.SetActive (true);
			if (Input.GetKeyDown (KeyCode.Space)) {
				
				if (treasureArray.Length - 1 <= counter) {//if you have reached the last treasure
					Debug.Log ("WOW");
					didPlayerWin = true;
				} else { //otherwise, add another one on!
					counter++;
					treasureActive = treasureArray [counter];
					if (counter == 1) {
						locator.SetActive (false);
						playerLocator.SetActive (true);
					}
				}
			}
		} else if ((player.position - treasureActive.position).magnitude > 5f) {
			controlPrompt.SetActive (false);
		}

		if (didPlayerWin == false) {
			textObject.text = treasureString [counter];
		}
		}
	}
