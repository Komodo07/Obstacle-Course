using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rb;
    float timeToWait = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rb.useGravity = true;
        }
    }
}
