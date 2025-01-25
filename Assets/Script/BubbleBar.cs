using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BubbleBar : MonoBehaviour
{
    [SerializeField] private Image _bar;
    [SerializeField] private TextMeshProUGUI _barText;

    [SerializeField] private float minScale = 0.5f;
    [SerializeField] private float maxScale = 2f;

    private Bubble _bubble;

    private void Update()
    {
        if (_bubble != null)
        {
            float normalizedScale = Mathf.InverseLerp(minScale, maxScale, _bubble.transform.localScale.x);

            _bar.fillAmount = normalizedScale;

            UpdateBarText(normalizedScale);
        }
    }

    public void GetBubble(Bubble bubble)
    {
        _bubble = bubble; // Bu bar'a atanmış Bubble'ı kaydet
    }

    private void UpdateBarText(float normalizedScale)
    {
        int percentage = Mathf.RoundToInt(normalizedScale * 100);
        _barText.text = percentage + "%";
    }
}
