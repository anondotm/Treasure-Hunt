using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {
	bool didPlayerWin = false;
	public Text controlPrompt;
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
				textObject.text = "You can leave now!";
		} 
		else if ((player.position - treasureActive.position).magnitude < 5f) {
			//controlPrompt.SetActive (true);
			if (Input.GetKeyDown (KeyCode.Space)) {
				
				if (counter >= treasureArray.Length) {//if you have reached the last treasure
					//didPlayerWin = true;
					Debug.Log("You can go back!");
				} 

				else { //otherwise, add another one on!
					counter++;
				}
			}
		}

		if (didPlayerWin == false) {
			textObject.text = treasureString [counter];
		}
		}
	}
