using UnityEngine;

public class E15_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int playerA;
        int playerB;
        int playerAResults = 0;
        int playerBResults = 0;
        while (playerAResults < 5 && playerBResults < 5){
  playerA = Random.Range(1, 4);
        playerB = Random.Range(1, 4);
        if (playerA == 1 && playerB == 2)
        {
            Debug.Log("Player1 Rock vs Player2 Paper");
            Debug.Log("Player2 Wins");
                playerBResults++;

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
                playerAResults++;

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
                playerAResults++;

            }
        if (playerA == 2 && playerB == 3)
        {
            Debug.Log("Player1 Paper vs Player2 Scissors");
            Debug.Log("Player2 Wins");
                playerBResults++;

            }
        if (playerA == 3 && playerB == 2)
        {
            Debug.Log("Player1 Scissors vs Player2 Paper");
            Debug.Log("Player1 Wins");
                playerAResults++;
            }
        if (playerA == 3 && playerB == 1)
        {
            Debug.Log("Player1 Scissors vs Player2 Rock");
            Debug.Log("Player2 Wins");
                playerBResults++;

            }
        if (playerA == 3 && playerB == 3)
        {
            Debug.Log("Player1 Scissors vs Player2 Scissors");
            Debug.Log("Draw");

        }
            
        }
        if(playerAResults == 5)
        {
            Debug.Log("Player1 wins");
        }
        else
        {
            Debug.Log("Player2 wins");
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
