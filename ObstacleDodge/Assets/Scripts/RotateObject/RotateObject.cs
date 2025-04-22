using UnityEngine;

public interface IRotateObject
{
    void FlipRotation();
    void TurnRotationOnOrOff(bool bOn);
}

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float RotationRate = 10.0f;

    private bool bRotateClockwise = true;
    private float yRotation = 0.0f;

    [SerializeField] private bool bShouldRotate = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bShouldRotate)
        {
            if (bRotateClockwise)
            {
                yRotation = RotationRate * Time.deltaTime;
            }
            else
            {
                yRotation = -RotationRate * Time.deltaTime;
            }

            this.gameObject.transform.Rotate(0.0f, yRotation, 0.0f);
        }
    }

    public void FlipRotation()
    {
        bRotateClockwise = !bRotateClockwise;
    }

    public void TurnRotationOnOrOff(bool bOn)
    {
        bShouldRotate = bOn;
    }
}
