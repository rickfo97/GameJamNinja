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
        if(other.tag == "Target")
        {
            Destroy(other);
            GameManager.gm.changeHealth(-10);
        }
    }
}
