using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You reached the finish!");
        }
    }
}
