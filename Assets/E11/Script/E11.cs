using UnityEngine;

public class E11 : MonoBehaviour
{
    public int playerA;
    public int playerB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerB = Random.Range(1, 4);
        if (playerA == 1 && playerB == 2)
        {
            Debug.Log("Player1 Rock vs Player2 Paper");
            Debug.Log("Player2 Wins");

        }
        if (playerA == 1 && playerB == 1)
        {
            Debug.Log("Player1 Rock vs Player2 Rock");
            Debug.Log("Draw");

        }
        if (playerA == 1 && playerB == 3)
        {
            Debug.Log("Player1 Rock vs Player2 Scissors");
            Debug.Log("Player1 Wins");

        }
        if (playerA == 2 && playerB == 2)
        {
            Debug.Log("Player1 Paper vs Player2 Paper");
            Debug.Log("Draw");

        }
        if (playerA == 2 && playerB == 1)
        {
            Debug.Log("Player1 Paper vs Player2 Rock");
            Debug.Log("Player1 Wins");

        }
        if (playerA == 2 && playerB == 3)
        {
            Debug.Log("Player1 Paper vs Player2 Scissors");
            Debug.Log("Player2 Wins");

        }
        if (playerA == 3 && playerB == 2)
        {
            Debug.Log("Player1 Scissors vs Player2 Paper");
            Debug.Log("Player1 Wins");

        }
        if (playerA == 3 && playerB == 1)
        {
            Debug.Log("Player1 Scissors vs Player2 Rock");
            Debug.Log("Player2 Wins");

        }
        if (playerA == 3 && playerB == 3)
        {
            Debug.Log("Player1 Scissors vs Player2 Scissors");
            Debug.Log("Draw");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
