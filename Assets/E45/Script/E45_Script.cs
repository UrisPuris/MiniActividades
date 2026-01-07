using UnityEngine;

public class E45_Script : MonoBehaviour
{
  
    public float speed = 2f;
    private float speedcirculo = 1f;
    private float lejo = 10f;
    public float offset = 0.5f;
    public GameObject Cap1;
    public GameObject Cap2;
    public GameObject Cap3;
    public GameObject Cap4;
    public GameObject Camera;
    private Vector3 inicioCap2, inicioCap3, inicioCap4;
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
       
       
        Vector3 targetCap2 = Cap1.transform.TransformPoint(new Vector3(offset, 0, lejo));
        Cap2.transform.position = Vector3.Lerp(inicioCap2, targetCap2, 0.3f);
        Vector3 targetCap3 = Cap1.transform.TransformPoint(new Vector3(offset * 2, 0, lejo * 2));
        Cap3.transform.position = Vector3.Lerp(inicioCap3, targetCap3, 0.5f);
        Vector3 targetCap4 = Cap1.transform.TransformPoint(new Vector3(offset * 3, 0, lejo * 3));
        Cap4.transform.position = Vector3.Lerp(inicioCap4, targetCap4, 0.1f);


        Vector3 targetCamera = Cap1.transform.TransformPoint(new Vector3(offset, 0, -lejo));
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, targetCamera, speedcirculo * Time.deltaTime);

      
       


    }
}

    

