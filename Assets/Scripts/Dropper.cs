using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidbody;
    MeshRenderer meshRenderer;
    float timeToWait = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
