using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParticlesToPlayerColor : MonoBehaviour
{


    [SerializeField] private ColorVariable playersColor;

    [SerializeField] private ParticleSystem PlayerDeathParticles;
    private void Start()
    {
        var main = PlayerDeathParticles.main;
        main.startColor = new Color(playersColor.Value.r, playersColor.Value.g, playersColor.Value.b, 1);

    }
}
