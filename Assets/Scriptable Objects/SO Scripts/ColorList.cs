using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ColorList",
    fileName = "New ColorList")]

public class ColorList : ScriptableObject
{
    public Color[] colors;
}
