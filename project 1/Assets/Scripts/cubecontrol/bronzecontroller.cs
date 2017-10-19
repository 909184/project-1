using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bronzecontroller : MonoBehaviour {

	void OnMouseDown() {
		gamecontroller.playerScore += gamecontroller.bronzeScore;
		gamecontroller.bronzeOre++;
		Destroy (gameObject);

		gamecontroller.bronzeSupply--;
	}
}
