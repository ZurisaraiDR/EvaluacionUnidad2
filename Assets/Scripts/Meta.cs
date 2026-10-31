using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
    
        if (other.CompareTag("Jugador"))
        {
            Debug.Log("META");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}  