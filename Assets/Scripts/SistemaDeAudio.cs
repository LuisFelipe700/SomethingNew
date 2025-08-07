using UnityEngine;

public class SistemaDeAudio : MonoBehaviour
{
    [Header("Fontes de Audio")]
    [SerializeField] private AudioSource bgAudio;
    [SerializeField] private AudioSource sfxAudio;
    [Header("Volumes dos Audios")]
    [Range(0f, 1f)][SerializeField] private float bgVolume = 0.5f;
    [Range(0f, 1f)][SerializeField] private float sfxVolume = 0.5f;
    private static SistemaDeAudio Instance;

     private void Awake()
    {
       if(Instance != null && Instance != this )
        {
            Destroy(gameObject);
            return;
        }
        
       Instance = this;
        DontDestroyOnLoad(gameObject);

        bgAudio = GameObject.Find("BgAudio").GetComponent<AudioSource>();
        sfxAudio = GameObject.Find("SFXAudio").GetComponent<AudioSource>();

    }

    public  void PlayBackGroundMusic(AudioClip clip)
    {
        bgAudio.clip = clip;
        bgAudio.volume = bgVolume;
        bgAudio.loop = true;
        bgAudio.Play();
    }

    public void PlaySoundEffects(AudioClip clip)
    {
        sfxAudio.volume = sfxVolume;
        sfxAudio.PlayOneShot(clip);
    }

}
