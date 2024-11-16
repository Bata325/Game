using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void changescene(int sceneindex)
    {
        SceneManager.LoadScene(1);
    }
}
