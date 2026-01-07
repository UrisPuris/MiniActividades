using UnityEngine;

public class E29_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float posision = Random.Range(-10f, 10f);
        transform.position = new Vector3(posision, 4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
