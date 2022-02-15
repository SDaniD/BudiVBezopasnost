using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClickHover : MonoBehaviour
{
    public AudioSource click;
    public AudioSource hover;
    public void ClickSound()
    {
        click.Play();
    }
    public void HoverSound()
    {
        hover.Play();
    }
}
