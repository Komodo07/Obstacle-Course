using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeed;       

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
