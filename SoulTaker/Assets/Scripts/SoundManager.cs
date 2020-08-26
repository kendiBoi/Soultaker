using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip JumpSound, HitSound, AttackSound, EnemyDeathSound, PauseMenuSound, PlayerDeathSound, ButtonSound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        JumpSound = Resources.Load<AudioClip>("sfx_movement_jump19");
        HitSound = Resources.Load<AudioClip>("sfx_damage_hit1");
        AttackSound = Resources.Load<AudioClip>("sfx_wpn_laser11");
        EnemyDeathSound = Resources.Load<AudioClip>("sfx_deathscream_alien1");
        PauseMenuSound = Resources.Load<AudioClip>("sfx_sounds_pause7_in");
        PlayerDeathSound = Resources.Load<AudioClip>("sfx_deathscream_alien3");
        ButtonSound = Resources.Load<AudioClip>("sfx_sounds_impact1");

        audioSource = GetComponent<AudioSource>();
}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Jump": audioSource.PlayOneShot(JumpSound); break;
            case "Hit": audioSource.PlayOneShot(HitSound); break;
            case "Attack": audioSource.PlayOneShot(AttackSound);break;
            case "EnemyDeath": audioSource.PlayOneShot(EnemyDeathSound); break;
            case "PauseMenu": audioSource.PlayOneShot(PauseMenuSound); break;
            case "PlayerDeath": audioSource.PlayOneShot(PlayerDeathSound); break;
            case "ButtonSound": audioSource.PlayOneShot(ButtonSound); break;
        }
    }
}
