using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDroppingObject
{
    void Drop();
    void SetRendererEnabled(bool enabled);
}

public class DroppingObject : MonoBehaviour, IDroppingObject
{
    private Renderer theRenderer;
    private Rigidbody theRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theRenderer = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody>();
        theRigidbody.useGravity = false;
        SetRendererEnabled(false);

        StartCoroutine(SetVisibleAndDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drop()
    {
        theRigidbody.useGravity = true;
    }

    public void SetRendererEnabled(bool enabled)
    {
       // Debug.Log("Setting renderer enabled to : " + enabled);
        theRenderer.enabled = enabled;
    }

    IEnumerator SetVisibleAndDrop()
    {
        
        yield return new WaitForSeconds(3);
       // Debug.Log("Start dropping object");
        SetRendererEnabled(true);
        Drop();
    }
}
