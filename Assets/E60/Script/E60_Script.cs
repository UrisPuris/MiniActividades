using UnityEngine;
using TMPro;

public class E60 : MonoBehaviour
{
    public float speed;
    public GameObject Cuadrao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text Numero;
    int counter = 0;
    public void AddPoints()
    {

        
            counter++;
            Numero.text = counter.ToString();
        



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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Cuadrao, transform.position, transform.rotation);
            AddPoints();
        }
    }
}

