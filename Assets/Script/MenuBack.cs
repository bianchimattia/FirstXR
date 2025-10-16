using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuBack : MonoBehaviour
{
    public void StartScene()
    {
        Debug.Log("Button clicked!");
        SceneManager.LoadScene("Menu");
    }

}
