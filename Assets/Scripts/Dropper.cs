using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime;

    Rigidbody rb;
    MeshRenderer isVisible;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isVisible = GetComponent<MeshRenderer>();
        isVisible.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > waitTime)
        {
            isVisible.enabled = true;
            rb.useGravity = true;
        }
    }
}
