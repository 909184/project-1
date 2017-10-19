using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

	int startMining;
	public int miningSpeed;

	public static int bronzeOre;
	public static int silverOre;
	public static int goldOre;
	public static int bronzeSupply;
	public static int silverSupply;
	public static int goldSupply;

	public static int bronzeScore;
	public static int silverScore;
	public static int goldScore;
	public static int playerScore;

	GameObject bronzeCube;
	GameObject silverCube;
	GameObject goldCube;

	public GameObject bronzePrefab;
	public GameObject silverPrefab;
	public GameObject goldPrefab;
	Vector3 cubePostion;



	// Use this for initialization
	void Start () {

		startMining = 3;
		miningSpeed = 3;
		bronzeOre = 0;
		silverOre = 0;
		goldOre = 0;
		bronzeSupply = 0;
		silverSupply = 0;
		goldSupply = 0;

		bronzeScore = 1;
		silverScore = 10;
		goldScore = 100;
		playerScore = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > startMining) {


		//spawn silver ore
			if (bronzeSupply >= 4) {

				cubePostion = new Vector3 (Random.Range (-7, 8), Random.Range (-7, 8), Random.Range (-7, 8));
				silverCube = Instantiate (silverPrefab, cubePostion, Quaternion.identity);

				silverCube.GetComponent<Renderer> ().material.color = Color.white;

				silverSupply += 1;
			}

			//spawn gold ore
			else if (bronzeSupply == 2 && silverSupply == 2) {
				cubePostion = new Vector3 (Random.Range (-7, 8), Random.Range (-7, 8), Random.Range (-7, 8));
				goldCube = Instantiate (goldPrefab, cubePostion, Quaternion.identity);

				goldCube.GetComponent<Renderer> ().material.color = Color.yellow;

				goldSupply += 1;

			}

		//spawn bronze ore
			if (bronzeSupply < 4) {
				bronzeSupply += 1;


				cubePostion = new Vector3 (Random.Range (-7, 8), Random.Range (-7, 8), Random.Range (-7, 8));
				bronzeCube = Instantiate (bronzePrefab, cubePostion, Quaternion.identity);

				bronzeCube.GetComponent<Renderer> ().material.color = Color.red;

			}

				print ("Bronze:" + bronzeOre + "    Silver:" + silverOre + "    Gold:" + goldOre);

				startMining += miningSpeed;
				
			print ("Score:" + playerScore);
		}
	}
}

