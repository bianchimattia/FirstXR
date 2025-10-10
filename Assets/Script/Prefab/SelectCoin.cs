using System.Collections;
using UnityEngine;

public class SelectCoin : MonoBehaviour
{
    public GameObject coin;
    [SerializeField] private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       var manager = GameObject.Find("GameManager");
       gameManager = manager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectedCoin()
    {
        StartCoroutine(DestroyCoin(coin));
    }

    IEnumerator DestroyCoin(GameObject coin)
    {
        //coinEffect.Play();
        gameManager.AddPoint();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        yield return null;
    }
}
