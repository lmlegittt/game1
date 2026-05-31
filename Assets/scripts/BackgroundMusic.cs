using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundmusic;
    private BackgroundMusic backgroundMusic;

    void Awake()
    {
        if (backgroundmusic == null) 
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else 
        {
            Destroy(gameObject);
        }
    }

}
