using UnityEngine;

public class E25_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D vola;
        vola = GetComponent<Rigidbody2D>();
        float magnitud = 5;
        vola.AddForce(new Vector3(0, 1, 0) * magnitud, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
