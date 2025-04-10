using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float horizMoveRate = 1.0f;
    [SerializeField] float vertMoveRate = 1.0f;
    float deltaX = 0f;
    float deltaZ = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogTest("Welcome to the game.");
        LogTest("Avoid objects and get to the goal.");
        LogTest("The walls are invisible.");
        LogTest("Good luck!");
    }
    
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        //transform.position = Vector3.Lerp(currentPos, newPos, Time.deltaTime);
    }

    void MovePlayer()
    {
        deltaX = Input.GetAxis("Horizontal");
        deltaZ = Input.GetAxis("Vertical");
        transform.Translate(transform.right * (deltaX * horizMoveRate * Time.deltaTime));
        transform.Translate(transform.forward * (deltaZ * vertMoveRate * Time.deltaTime));
    }

    void LogTest(String SomeMessage)
    {
        Debug.Log(SomeMessage);
    }

    float zResult = 0f;
    float deltaTime = 0f;
    bool bMoveForward = true;
    // Use delta time to lerp the mover between z positions. TODO: make forward vector.
    void PingPong(float deltaTime)
    {
        //if (bMoveForward)
        //{
        //    zResult = transform.position.z + zMoveRate;
        //}
        //else
        //{
        //    zResult = transform.position.z - zMoveRate;
        //}
        //Vector3 newTransform = new Vector3(transform.position.x, transform.position.y, zResult);
        //transform.position = Vector3.Lerp(transform.position, newTransform, deltaTime);
        //if (transform.position.z > 2.0f)
        //{
        //    bMoveForward = false;
        //}
        //if (transform.position.z < 0f)
        //{
        //    bMoveForward = true;
        //}
    }
}
