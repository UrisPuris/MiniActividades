using UnityEngine;

public class E07Script : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public string operation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (operation)
        {
            case "+":
                Debug.Log(numero1 + numero2);
                break;
            case "-":
                Debug.Log(numero1 - numero2);
                break;
            case "*":
                Debug.Log(numero1 * numero2);
                break;
            case "/":
                Debug.Log(numero1 / numero2);
                break;
            case "%":
                Debug.Log(numero1 % numero2);
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
