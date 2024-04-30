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
        // ������� ���������� AudioSource � Animator �� �������, � �������� �������� ������
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // ���������, ���� �� ������ ������ ������ ����
        if (Input.GetMouseButtonDown(1))
        {
            ToggleSound();
        }
    }

    void ToggleSound()
    {
        // ���� ���� �������, �� ��������� ���, ����� ��������
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