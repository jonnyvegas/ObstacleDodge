using System;
using UnityEngine;

public class TriggerForFlyingObstacles : MonoBehaviour
{

    [SerializeField] private GameObject[] obstacles;
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
        // Player is the one who activates via walking into trigger
        if (other.gameObject.CompareTag("Player"))
        {
            
            foreach (GameObject obstacle in obstacles)
            {
                IFlyAtPlayer flyAtPlayerRef;
                if (obstacle.TryGetComponent<IFlyAtPlayer>(out flyAtPlayerRef))
                {
                    flyAtPlayerRef.StartMoving();
                }
            }
        }
        
        // this is what we'll call for flying objects
        //throw new NotImplementedException();
    }
}
