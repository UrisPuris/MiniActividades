using UnityEngine;

public class E55_Script : MonoBehaviour
{
    public Animator Ouchis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ouchis = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ouchis.Play("Auch");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ouchis.Play("New Animation");
        }
    }
}
