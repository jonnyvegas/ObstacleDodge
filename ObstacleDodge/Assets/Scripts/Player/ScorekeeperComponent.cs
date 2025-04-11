using UnityEngine;



public interface IScorekeeper
{
    void AddScore(int Score);
    void RemoveScore(int Score);
}

public class ScorekeeperComponent : MonoBehaviour, IScorekeeper
{
    int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int Score)
    {
        this.Score += Score;
        PrintScore();
    }

    public void RemoveScore(int Score)
    {
        this.Score -= Score;
        PrintScore();
    }

    void PrintScore()
    {
        Debug.Log("Current Score: " + this.Score);
    }
}
