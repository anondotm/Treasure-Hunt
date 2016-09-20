using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {
	bool didPlayerWin = false;
	public GameObject locator; //locator object in the world
	public GameObject playerLocator; //locator object attached to player
	public GameObject controlPrompt; //prompt player to observe/pickup with space
	public Text textObject;
	public string[] treasureString; //array of messages for "textObject"
	public Transform player; //player position
	public Transform treasureActive; //treasure from Array that the player must look for
	public Transform[] treasureArray; //array of treasure Transforms
	public int counter; //counter variable

	public GameObject audioAmbiance; //activate once player nears the town and observes the satellite
	// Use this for initialization
	void Start () {
		counter = 0;
		treasureActive = treasureArray [counter];
	}
	
	// Update is called once per frame
	void Update () {


		if (didPlayerWin) {
			textObject.text = "You found your ship! Press '[SPACE]' again to return to your mission.";
			controlPrompt.SetActive (false);
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
					} else if (counter == 2) {
						audioAmbiance.SetActive (true);
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
