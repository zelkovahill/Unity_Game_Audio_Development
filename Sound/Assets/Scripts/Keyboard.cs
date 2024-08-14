using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private AudioSource audioSource;
    public int transpose = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        var note = -1;
        if (Input.GetKeyDown(KeyCode.A)) note = 0;
        if (Input.GetKeyDown(KeyCode.S)) note = 2;
        if (Input.GetKeyDown(KeyCode.D)) note = 4;
        if (Input.GetKeyDown(KeyCode.F)) note = 5;
        if (Input.GetKeyDown(KeyCode.G)) note = 7;
        if (Input.GetKeyDown(KeyCode.H)) note = 9;
        if (Input.GetKeyDown(KeyCode.J)) note = 11;
        if (Input.GetKeyDown(KeyCode.K)) note = 12;
        if (Input.GetKeyDown(KeyCode.L)) note = 14;

        if (note >= 0 && audioSource != null)
        {
            audioSource.pitch = Mathf.Pow(2, (note + transpose) / 12.0f);
            audioSource.Play();
        }
    }
}
