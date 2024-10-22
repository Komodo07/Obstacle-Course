using System;
using UnityEngine;

public class Mover : MonoBehaviour
{

    float moveSpeed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Console.Clear();
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Move the player with WASD or arrow keys.");
        Debug.Log("Don't hit the walls!");
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
