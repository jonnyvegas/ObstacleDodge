using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float RotationRate = 10.0f;

    private bool bRotateClockwise = true;
    private float yRotation = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

    void FlipRotation()
    {
        bRotateClockwise = !bRotateClockwise;
    }
}
