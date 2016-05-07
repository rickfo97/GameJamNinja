using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour {

    public GameObject target;
    public float interval;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnTarget", interval, interval);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnTarget()
    {
        Instantiate(target, gameObject.transform.position, gameObject.transform.rotation);
    }
}
