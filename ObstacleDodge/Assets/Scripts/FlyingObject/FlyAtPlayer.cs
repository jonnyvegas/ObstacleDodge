using System.Collections;
using UnityEngine;

public interface IFlyAtPlayer
{
    void StartMoving();
}

public class FlyAtPlayer : MonoBehaviour, IFlyAtPlayer
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.0f;
    private float timePassed = 0.0f;
    private Vector3 parsedPlayerPosition;

    private bool bStartMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.SetActive(false);
        //StartCoroutine(ParsePlayerLocationCoroutine(3));
    }

    // Update is called once per frame
    void Update()
    {
        if (bStartMoving)
        {
            HandleMoveTowards();
        }
        
    }

    IEnumerator ParsePlayerLocationCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        ParsePlayerLocation();
        //yield return null;
    }

    void ParsePlayerLocation()
    {
        parsedPlayerPosition = player.transform.position;
        bStartMoving = true;
    }

    void HandleMoveTowards()
    {
        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, parsedPlayerPosition,speed * Time.deltaTime);
        if (Vector3.Distance(transform.position,  parsedPlayerPosition) < 0.1f )
        {
            bStartMoving = false;
            GetRidOfObject(this.gameObject);
        }

    }

    void GetRidOfObject(GameObject theObject)
    {
        //Destroy(theObject);
        theObject.SetActive(false);
    }

    void SetStartMoving(bool moving)
    {
        bStartMoving = moving;
    }

    public void StartMoving()
    {
        SetStartMoving(true);
    }
}
