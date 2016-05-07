using UnityEngine;
using System.Collections;

public class Chaser : MonoBehaviour
{

    public float speed = 20.0f;
    public float minDist = 1f;
    public Transform target;

    void Start()
    {
        if (target == null)
        {

            if (GameObject.FindWithTag("Katana") != null)
            {
                Debug.Log("Found Katana!");
                target = GameObject.FindWithTag("Katana").GetComponent<Transform>();
            }
        }
    }

    void Update()
    {
        if (target == null)
            return;

        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > minDist)
            transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

}

