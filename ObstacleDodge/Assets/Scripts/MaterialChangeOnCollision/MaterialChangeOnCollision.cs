using UnityEngine;

public interface IMaterialChangeOnCollision
{
    void ChangeMaterial(Material m);
}

public class MaterialChangeOnCollision : MonoBehaviour, IMaterialChangeOnCollision
{
    //[SerializeField] private Material onCollisionMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void ChangeMaterial(Material m)
    {
        MeshRenderer theRenderer = this.gameObject.GetComponent<MeshRenderer>();
        if (m && theRenderer)
        {
            theRenderer.material = m;
        }
    }
}

public class ObstacleChangeMaterial : MaterialChangeOnCollision
{
    public override void ChangeMaterial(Material m)
    {
        base.ChangeMaterial(m);
        Debug.Log("ObstacleChangeMaterial");
    }
}

public class WallChangeMaterial : MaterialChangeOnCollision
{
    public override void ChangeMaterial(Material m)
    {
        base.ChangeMaterial(m);
        Debug.Log("WallChangeMaterial");
    }
}
