using UnityEngine;

public class E14_script : MonoBehaviour
{
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i;
        int j;
        for (i = 0; i <= 10; i++)
        {

         for (j = 0; j <= 10; j++)
            {
                Debug.Log(i * j);
            }  

            
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
