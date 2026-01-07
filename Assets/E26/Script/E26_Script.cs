using UnityEngine;

public class E26_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D vola;
        vola = GetComponent<Rigidbody2D>();
        float magnitud = 5;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vola.AddForce(new Vector3(0, 1, 0) * magnitud, ForceMode2D.Impulse);
        }
    }
}
