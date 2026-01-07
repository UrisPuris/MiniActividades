using UnityEngine;
using UnityEngine.SceneManagement;

public class E67_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("e67_blue");
        }
    }

}
