using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, player.gameObject.transform.position, speed * Time.deltaTime);
    }
}
