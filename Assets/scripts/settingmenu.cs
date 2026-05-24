using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class settingmenu : MonoBehaviour
{
    [SerializeField] private Slider qualitySlider;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private AudioMixer mixer;


    private void Start()
    {
        RefreshSettings();
    }


    public void RefreshSettings() 
    {
        qualitySlider.value = setting.QualityLevel;
        volumeSlider.value = setting.Volume;

        Apply();
    }


    public void Apply() 
    {
        setting.QualityLevel = (int)qualitySlider.value;
        setting.Volume = volumeSlider.value;

        QualitySettings.SetQualityLevel(setting.QualityLevel);
        mixer.SetFloat("Master", Mathf.Log10(setting.Volume) * 20);
    }

}
