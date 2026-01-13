using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    private FMOD.Studio.VCA vca;
    public Slider Slider;


    [Header("Ustawienia FMOD")]
    [SerializeField] private string vcaPath;
    [SerializeField] private string saveKey;

    [Header("Poziom G³oœnoœci")]
    [SerializeField] private float vcaVolume;
    private void Start()
    {
        Slider = GetComponent<Slider>();
        vca = FMODUnity.RuntimeManager.GetVCA(vcaPath);

        float savedVolume = PlayerPrefs.GetFloat(saveKey, 1);
        
        vca.getVolume(out vcaVolume);
        Slider.value = savedVolume;
    }

    public void SetVolume(float volume)
    {
        vca.setVolume(volume);

        PlayerPrefs.SetFloat(saveKey, volume);
    }
}
