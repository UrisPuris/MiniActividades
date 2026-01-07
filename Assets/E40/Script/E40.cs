using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class E40 : MonoBehaviour
{
    public TMP_Text Numero;
    int counter = 0;
   public void AddPoints()
    {
        counter++;
        Numero.text = counter.ToString();

    }
}
