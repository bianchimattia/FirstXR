using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int punti = 0;
    public int migliore = 0;

    public TextMeshProUGUI punteggio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetInt("punteggio", 0);
        PlayerPrefs.SetInt("migliore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        
        punti = PlayerPrefs.GetInt("punteggio");
        migliore = PlayerPrefs.GetInt("migliore");
        punti += 1;
        if(punti>migliore)
        {
            PlayerPrefs.SetInt("migliore", punti);
        }
        punteggio.text = "Punteggio: " + punti.ToString();
    }
}
