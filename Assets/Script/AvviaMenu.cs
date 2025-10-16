using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvviaMenu : MonoBehaviour
{
    public TextMeshProUGUI migliore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        migliore.text = "Miglior punteggio: " + PlayerPrefs.GetInt("migliore");
    }

    public void StartScene()
    {
        SceneManager.LoadScene("BasicScene");
    }

}
