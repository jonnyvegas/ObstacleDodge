using UnityEngine;

public class ObsctacleCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        // see what hit us. We may need to do something to the player here.
        Debug.Log("something hit " + this.gameObject.name + ". it's: " + other.gameObject.name);
    }
}
