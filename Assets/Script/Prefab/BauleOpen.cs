using System.Collections;
using UnityEngine;

public class BauleOpen : MonoBehaviour
{

    private const float differenzaZ = 0.73f;
    public float velocita = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApriBaule()
    {
        StartCoroutine(ApriBauleCoroutine());
    }

    private IEnumerator ApriBauleCoroutine() {

        // posizione attuale
        Vector3 startPos = transform.position;
        // pos finale
        Vector3 destinazione = new Vector3(
            startPos.x,
            startPos.y,
            startPos.z + differenzaZ
        );

        while (Vector3.Distance(transform.position, destinazione) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                destinazione,
                velocita * Time.deltaTime
            );

            yield return null;
        }

        transform.position = destinazione;
    }
}
