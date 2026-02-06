using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void materi()
    {
        SceneManager.LoadScene("MenuBAB");
    }
    public void marker()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1ynl42-tASzBBrNmn90GzUokzpxCsxVqn");
    }
    public void quiz()
    {
        SceneManager.LoadScene("Quiz");
    }
    public void back()
    {
        SceneManager.LoadScene("Home");
    }
    public void scan()
    {
        SceneManager.LoadScene("MenuScan");
    }
}
