using UnityEngine;

public class E10_Script : MonoBehaviour
{
    private int operation;
    private int numero1;
    private int numero2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        operation = Random.Range(0, 5);
        numero1 = Random.Range(0, 10);
        numero2 = Random.Range(0, 10);

        Debug.Log(numero1);
        switch (operation)
        {
            case 1:
                Debug.Log("+");
                break;
            case 2:
                Debug.Log("-");
                break;
            case 3:
                Debug.Log("*");
                break;
            case 4:
                Debug.Log("/");
                break;
            case 5:
                Debug.Log("%");
                break;
        }
        
        Debug.Log(numero2);
        switch (operation)
        {
            case 1:
                Debug.Log(numero1 + numero2);
                break;
            case 2:
                Debug.Log(numero1 - numero2);
                break;
            case 3:
                Debug.Log(numero1 * numero2);
                break;
            case 4:
                Debug.Log(numero1 / numero2);
                break;
            case 5:
                Debug.Log(numero1 % numero2);
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
