using UnityEngine;

public class E31_ScriptC : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entro");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Salio");
    }
}
