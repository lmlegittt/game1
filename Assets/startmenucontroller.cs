using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenucontroller : MonoBehaviour
{
    public void OnStartClick() 
    {
        SceneManager.LoadScene("level1");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }


}
