using UnityEngine;

public class E48_Script : MonoBehaviour
{
    public float speed = 2f;
  
   
    
    public GameObject Cap1;
    public GameObject Cap2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        Vector3 Sigueme = new Vector3(Cap1.transform.position.x, Cap2.transform.position.y, Cap2.transform.position.z);

        Cap2.transform.position = Sigueme;
       
    }
}
