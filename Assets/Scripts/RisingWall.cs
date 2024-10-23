using UnityEngine;

public class RisingWall : MonoBehaviour
{
    [SerializeField] GameObject risingWall;
    float raiseSpeed = 1f;
    bool isFlipped = false;


    // Update is called once per frame
    void Update()
    {
        if (isFlipped)
        {
            if (risingWall.transform.position.y <= 3.1f)
            {
                risingWall.transform.Translate(Vector3.up * raiseSpeed * Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            isFlipped = true;
        }
    }
}
