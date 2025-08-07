using TMPro;
using UnityEngine;

public class Avisos : MonoBehaviour
{


    public TextMeshProUGUI grimvalenText; // arraste o TextMeshPro aqui no Inspector
    public float displayTime = 3f; // tempo que o nome fica visível

    private bool hasEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasEntered && other.CompareTag("Player"))
        {
            hasEntered = true;
            StartCoroutine(ShowGrimvalenName());
        }
    }

    private System.Collections.IEnumerator ShowGrimvalenName()
    {
        grimvalenText.gameObject.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        grimvalenText.gameObject.SetActive(false);
    }
}


