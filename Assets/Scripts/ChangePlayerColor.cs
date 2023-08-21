using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerSpriteRenderer;

    [SerializeField] private ColorList playerColors;

    [SerializeField] private ColorVariable playersColor;

    public Color playerColor;
    void Awake()
    {
        playerColor = playerColors.colors[Random.Range(0, playerColors.colors.Length - 1)];
        playerSpriteRenderer.color = new Color(playerColor.r, playerColor.g, playerColor.b, 1);

        playersColor.Value = playerColor;
    }
}
