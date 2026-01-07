using UnityEngine;

public class E57 : MonoBehaviour
{
    public float magnitud = 2;
    public float speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerStay2D(Collider2D collision)
    {
         
        if (collision.CompareTag("Bum") && Input.GetKey(KeyCode.Space))
        {
            float posision = Random.Range(-10f, 10f);
            
            Rigidbody2D Terrmita = collision.GetComponent<Rigidbody2D>();
            Terrmita.AddForce(new Vector3(posision,posision,0) * magnitud, ForceMode2D.Impulse);

        }
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
}
