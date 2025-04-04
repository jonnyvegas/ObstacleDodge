using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float horizMoveRate = 0.0f;
    [SerializeField] float vertMoveRate = 0.0f;
    [SerializeField] float zMoveRate = 0.01f;
    float zResult = 0f;
    float deltaTime = 0f;
    bool bMoveForward = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;

        if(bMoveForward)
        {
            zResult = transform.position.z + zMoveRate;
        }
        else
        {
            zResult = transform.position.z - zMoveRate;
        }
        Vector3 newTransform = new Vector3(transform.position.x, transform.position.y, zResult);
        transform.position = Vector3.Lerp(transform.position, newTransform, deltaTime);
        if(transform.position.z > 2.0f)
        {
            bMoveForward = false;
        }
        if(transform.position.z < 0f)
        {
            bMoveForward = true;
        }
        //Debug.Log("Y of new transform: " + newTransform.y);
        //transform.position = (Vector3.Slerp(transform.position, newTransform, deltaTime));
        //transform.Translate(horizMoveRate * deltaTime, vertMoveRate * deltaTime, 0);
    }
}
