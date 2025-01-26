using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class SettingsScript : MonoBehaviour
{
    public AudioMixer audiomixer;
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;
    private void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width&& resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolutionValue(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];

        Screen.SetResolution(resolution.width, resolution.height,Screen.fullScreen);
    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Volume",volume); 
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex, false);  
    }
    public void SetFulScreen(bool isfulscreen)
    {
        Screen.fullScreen = isfulscreen;
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
