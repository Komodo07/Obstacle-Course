using UnityEngine;

public class Slider : MonoBehaviour
{
    [SerializeField] float slideSpeed;
    bool open = false;    

    // Update is called once per frame
    void Update()
    {
        if (!open)
        {
            if (transform.position.z < -11.25f)
            {
                transform.Translate(Vector3.forward * slideSpeed * Time.deltaTime);
            }
            else
            {
                open = true;
            }            
        }

        if (open)
        {
            if (transform.position.z > -16.75f)
            {
                transform.Translate(Vector3.back * slideSpeed * Time.deltaTime);
            }
            else
            {
                open = false;
            }            
        }
    }
}
