using UnityEngine;
using TMPro;
public class E_60Text : MonoBehaviour
{
    public TMP_Text Numero;
    int counter = 0;
    public void AddPoints()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            Numero.text = counter.ToString();
        }

       

    }
}
