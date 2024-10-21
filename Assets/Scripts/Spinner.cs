using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue;
    [SerializeField] float yValue;
    [SerializeField] float zValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(xValue, yValue, zValue) * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
