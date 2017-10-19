using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silvercontroller : MonoBehaviour {
	
	void OnMouseDown() {
		gamecontroller.playerScore += gamecontroller.silverScore;
		gamecontroller.silverOre++;
		Destroy (gameObject);

		gamecontroller.silverSupply--;

	}

}


