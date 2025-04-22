using UnityEngine;

public interface IRotateObject
{
    void FlipRotation(bool bX, bool bY, bool bZ);
    void TurnRotationOnOrOff(bool bOn);
}

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float xRotationRate = 0.0f;
    [SerializeField] private float yRotationRate = 0.0f;
    [SerializeField] private float zRotationRate = 0.0f;

    //private bool bRotateClockwise = true;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private float zRotation = 0.0f;

    [SerializeField] private bool shouldRotate = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateTheObject();
    }

    void RotateTheObject()
    {
        if (shouldRotate)
        {
            
            xRotation = xRotationRate * Time.deltaTime;
            yRotation = yRotationRate * Time.deltaTime;
            zRotation = zRotationRate * Time.deltaTime;

            this.gameObject.transform.Rotate(xRotation, yRotation, zRotation);
        }
    }

    public void FlipRotation(bool bX, bool bY, bool bZ)
    {
        if (bX)
        {
            xRotationRate *= -1;
        }

        if (bY)
        {
            yRotationRate *= -1;
        }

        if (bZ)
        {
            zRotationRate *= -1;
        }
    }

    public void TurnRotationOnOrOff(bool bOn)
    {
        shouldRotate = bOn;
    }
}
