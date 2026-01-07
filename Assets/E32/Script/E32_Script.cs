using UnityEngine;

public class E32_Script : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public float speed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cuadrao1")
        {
            Debug.Log("Entro en el rojo");
        }
        if (collision.gameObject.tag == "Cuadrao 2")
        {
            Debug.Log("Entro en el azul");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cuadrao1")
        {
            Debug.Log("Salio del rojo");
        }
        if (collision.gameObject.tag == "Cuadrao 2")
        {
            Debug.Log("Salio del azul");
        }
    }
}
