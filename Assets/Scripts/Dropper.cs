using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rb;
    MeshRenderer meshRenderer;
    float timeToWait;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }*/
    }

    public void EnableObstacle()
    {
        meshRenderer.enabled = true;
        rb.useGravity = true;        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
