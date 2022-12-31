using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public  int score;
    public  int rounds;
    public BallSpawner ballSpawner;
    public static Goal goaaal;
    private void Awake()
    {
        if (goaaal != null) 
        {
            Destroy(gameObject);
            return;
        }
        goaaal = this;
        DontDestroyOnLoad(gameObject);

    }
    private void Start()
    {
       goaaal.score= 0;
       goaaal.rounds= ballSpawner.Rounds;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) 
        {
            goaaal.score++;
            Destroy(other.gameObject);
        }
    }
}
