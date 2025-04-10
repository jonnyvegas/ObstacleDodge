using System;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [SerializeField] private Material NewWallMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something hit us. it's: " + other.gameObject.name);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("something hit " + this.gameObject.name + ". it's: " + other.gameObject.name);
        
        // don't care if we didn't hit player.
        if (!other.gameObject.CompareTag("Player")) 
            return;
        
        // change the material color.
        MeshRenderer theRenderer = this.gameObject.GetComponent<MeshRenderer>();
        if (NewWallMaterial != null)
        {
            theRenderer.material = NewWallMaterial;
        }
    }
}
