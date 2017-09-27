using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

	int startMining;
	public int miningSpeed;

	int bronzeOre;
	int silverOre;
	public int bronzeSupply;
	public int silverSupply;

	GameObject bronzeCube;
	GameObject silverCube;

	public GameObject cubePrefab;
	Vector3 cubePostion;



	// Use this for initialization
	void Start () {

		startMining = 3;
		miningSpeed = 3;
		bronzeOre = 0;
		silverOre = 0;
		bronzeSupply = 3;
		silverSupply = 2;


	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > startMining) {

			if (bronzeSupply >= 1) {
				bronzeSupply -= 1;
				bronzeOre += 1;
			} 
			else if (silverSupply >= 1 && bronzeSupply == 0) {
				silverSupply -= 1;
				silverOre += 1;
			}

			print ("Bronze:" + bronzeOre + "    Silver:" + silverOre);

			startMining += miningSpeed;


				cubePostion = new Vector3 (Random.Range (-7, 8), Random.Range (-7, 8), Random.Range (-7, 8));
				silverCube = Instantiate (cubePrefab, cubePostion, Quaternion.identity);

				silverCube.GetComponent<Renderer> ().material.color = Color.white; 

				
			
			

				cubePostion = new Vector3 (Random.Range (-7, 8), Random.Range (-7, 8), Random.Range (-7, 8));
				bronzeCube = Instantiate (cubePrefab, cubePostion, Quaternion.identity);

				bronzeCube.GetComponent<Renderer> ().material.color = Color.red;

				
				
			}
		}
	}
}

