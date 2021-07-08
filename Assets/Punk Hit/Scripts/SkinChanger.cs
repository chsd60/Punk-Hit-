using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{

    public SpriteRenderer[] renderers;
    public Sprite[] skinElements;
    public void ChangeSkin()
    {
        for (var i = 0; i < renderers.Length; i++)
        {
            renderers[i].sprite = skinElements[i];
        }
    }
}
