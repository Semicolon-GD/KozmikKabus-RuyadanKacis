using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneSayaci : MonoBehaviour
{
   

    private float delayInSeconds = 7f; // Sahne de�i�ikli�i gecikme s�resi

    private void Start()
    {
        // Belirledi�iniz s�re sonunda sahneyi de�i�tirin

        StartCoroutine(LoadNextScene());
        
        // Invoke("LoadNextScene", delayInSeconds);
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(3);
    }
}