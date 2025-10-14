using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void BunnyCatch()
    {
        SceneManager.LoadScene("SaveBunny");
    }
    public void CandyCatch()
    {
        SceneManager.LoadScene("CandyCatch");
    }
}
