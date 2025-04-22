using UnityEngine;

public class ObsctacleCollision : MonoBehaviour
{
    private bool bHasCollidedWithPlayer = false;

    [SerializeField] private Material NewMaterial;

    private IMaterialChangeOnCollision MaterialChangeRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetMaterialChangeRef(gameObject.AddComponent<ObstacleChangeMaterial>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        // see what hit us. We may need to do something to the player here.
        //Debug.Log("something hit " + this.gameObject.name + ". it's: " + other.gameObject.name);
        // only players have scorekeepers currently but we could reuse this behavior to give scores
        // to other things.
        if (other.gameObject.TryGetComponent(out IScorekeeper theScorekeeper))
        {
            // hard coding for now - will update so each obstacle can have its' own score if desired.
            if (!bHasCollidedWithPlayer)
            {
                theScorekeeper.AddScore(1);
                bHasCollidedWithPlayer = true;
                MaterialChangeRef.ChangeMaterial(NewMaterial);
            }
        }
        else
        {
            //Debug.Log("Failed to get theScorekeeper. Sadge.");
        }
    }

    private void SetMaterialChangeRef(IMaterialChangeOnCollision MatChangeRef)
    {
        this.MaterialChangeRef = MatChangeRef;
        Debug.Log("SetMaterialChangeRef to " + MatChangeRef);
    }
}
