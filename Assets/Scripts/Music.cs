using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggle : MonoBehaviour
{
    [SerializeField] private GameObject _soundOn;
    [SerializeField] private GameObject _soundOff;
    private AudioSource audioSource;

    void Start()
    {
        // Находим компоненты AudioSource и Animator на объекте, к которому привязан скрипт
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Проверяем, была ли нажата правая кнопка мыши
        if (Input.GetMouseButtonDown(1))
        {
            ToggleSound();
        }
    }

    void ToggleSound()
    {
        // Если звук включен, то выключаем его, иначе включаем
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            _soundOn.SetActive(false);
            _soundOff.SetActive(true);
        }
        else
        {
            audioSource.UnPause();
            _soundOn.SetActive(true);
            _soundOff.SetActive(false);
        }
    }
}