using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co)
    {
        GameController.instance.Pass();
    }
}
