using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem _particleSystem;
    public void OnClick()
    {
        _particleSystem.Play();
    }
}
