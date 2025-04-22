using System.Collections;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.0f;
    private float timePassed = 0.0f;
    private Vector3 parsedPlayerPosition;

    private bool bStartMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ParsePlayerLocation());
    }

    // Update is called once per frame
    void Update()
    {
        if (bStartMoving)
        {
            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, parsedPlayerPosition,speed * Time.deltaTime);
        }
        
    }

    IEnumerator ParsePlayerLocation()
    {
        yield return new WaitForSeconds(3.0f);
        parsedPlayerPosition = player.transform.position;
        bStartMoving = true;
    }
}
