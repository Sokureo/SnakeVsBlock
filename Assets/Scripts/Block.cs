using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    public int Value;
    public TextMeshPro PointsText;
    Color lerpedColor = Color.white;

    void Start()
    {
        PointsText.SetText(Value.ToString());
        lerpedColor = Color.Lerp(Color.white, Color.red, (float)Value / 50f + 0.25f);
        this.GetComponent<Renderer>().material.color = lerpedColor;
    }
}
