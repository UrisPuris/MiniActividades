using UnityEngine;

public class E06_script : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int numero3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log ((numero1 + numero2 + numero3) / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
