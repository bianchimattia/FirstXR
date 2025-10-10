using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject porta;
    public Vector3 posizioneIniziale = new Vector3(-1.269f, 1.261f, 1.91f);
    public Vector3 posizioneFinale = new Vector3(-3.574f, 1.2751f, 1.91f);
    public float velocita = 2.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider oggetto)
    {
        if (oggetto.CompareTag("Tessera"))
        {
            ApriPorta();
        }
    }

    public void ApriPorta()
    {
        StartCoroutine(ApriPorta(posizioneFinale));
    }

    private IEnumerator ApriPorta(Vector3 destinazione)
    {
        while (Vector3.Distance(porta.transform.position, destinazione) > 0.01f)
        {
            // spostamento incrementale verso la destinazione
            porta.transform.position = Vector3.MoveTowards(
                porta.transform.position,
                destinazione,
                velocita * Time.deltaTime
            );

            yield return null; 
        }

        porta.transform.position = destinazione; 
    }
}
