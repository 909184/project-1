using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldcontroller: MonoBehaviour {
	
	void OnMouseDown() {
		gamecontroller.playerScore += gamecontroller.goldScore;
		gamecontroller.goldOre++;
		Destroy (gameObject);

		gamecontroller.goldSupply--;

	}
			
}
