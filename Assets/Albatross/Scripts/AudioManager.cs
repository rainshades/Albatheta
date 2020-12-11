
using UnityEngine;

namespace Albatross
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField]
        AudioClip OutOfCombatTrack = null;
        [SerializeField]
        AudioClip InCombatTrack = null;

        public AudioSource AudioSource;


        private void Awake()
        {
            AudioSource = FindObjectOfType<AudioSource>();
        }

        private void Update()
        {
            if (GameManager.Instance.inCombat && AudioSource.clip != InCombatTrack)
            {
                AudioSource.clip = InCombatTrack;
                AudioSource.Play();
            }

            if (AudioSource.clip != OutOfCombatTrack && !GameManager.Instance.inCombat)
            {
                AudioSource.clip = OutOfCombatTrack;
                AudioSource.Play();
            }
        }
    }
}