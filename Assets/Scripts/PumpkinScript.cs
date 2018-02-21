using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinScript : MonoBehaviour {

	// Use this for initialization
	void Update () {
        if (transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision target)
    {
        if ("Golem".Equals(target.gameObject.tag))
        {
            Destroy(target.gameObject);
            Time.timeScale = 0f;
        }
    }
}
