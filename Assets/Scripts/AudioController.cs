using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    private FMOD.Studio.VCA vca;
    public Slider slider;

    [SerializeField] private float vcaVolume;
    private void Start()
    {
        vca = FMODUnity.RuntimeManager.GetVCA(path: "vca:/Music");
        vca.getVolume(out vcaVolume);
    }

    public void GetVolume(float volume)
    {
        vca.setVolume(volume);
    }
}
