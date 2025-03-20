
using UnityEngine;

public class Effect : MonoBehaviour
{
    public ParticleSystem Particle;
    private bool effectPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        if(Particle != null)
        {
            Particle.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Score.score >= 20 && !effectPlayed)
        {
            PlayEffect();
            effectPlayed = true;
        }
    }

    void PlayEffect()
    {
        if(Particle != null)
        {
            Particle.Play();
        }
    }
}
