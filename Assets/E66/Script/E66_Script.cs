using UnityEngine;
using UnityEngine.SceneManagement;
public class E66_Script : MonoBehaviour
{
   

    public void Verde()
    {
        SceneManager.LoadScene("e66_green");
     
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
       
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("e66_red");
        }
        else{
       Invoke("Verde", 10f);
        }
      
    }
    public void Rojo()
    {
        SceneManager.LoadScene("e66_blue");
    }

    



}
