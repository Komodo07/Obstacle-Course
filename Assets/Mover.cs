using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0f;
    float yValue = 0.01f;
    float zValue = 0f;    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(xValue, yValue, zValue);
        transform.Translate(movement * Time.deltaTime * 10);
    }
}
