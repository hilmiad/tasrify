using UnityEngine;
using UnityEngine.SceneManagement;

public class backplay : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}