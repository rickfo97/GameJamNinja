using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");

        if(other.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.gm.changeHealth(-10);
        }
    }
}
