using System.Collections;
using UnityEngine;

public class Timekeeper : MonoBehaviour
{
    private Coroutine theRoutine;

    private float timePassed = 0;

    private int countSeconds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // theRoutine = StartCoroutine(CountOneSecond());
        countSeconds = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= countSeconds + 1)
        {
            countSeconds++;
            //Debug.Log(countSeconds);
        }
    }

    IEnumerator CountOneSecond()
    {
        while (true)
        {
            timePassed += 1;
            Debug.Log("Time passed: " + timePassed);
            yield return new WaitForSeconds(1);
        }
    }
}
