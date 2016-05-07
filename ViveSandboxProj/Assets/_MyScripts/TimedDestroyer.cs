using UnityEngine;
using System.Collections;

public class TimedDestroyer : MonoBehaviour {

    [SerializeField]private float time;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;

        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
}
