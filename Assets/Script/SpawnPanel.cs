using UnityEngine;
using System.Collections;


public class SpawnPanel : MonoBehaviour
{
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPanelM()
    {
        StartCoroutine(SpawnPanelC(panel));
    }

    IEnumerator SpawnPanelC(GameObject panel)
    {
        panel.SetActive(true);
        yield return null;
    }
}
