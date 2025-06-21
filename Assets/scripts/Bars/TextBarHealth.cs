using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextBarHP : HealthBar
{
    private TextMeshProUGUI _textField;

    private void Awake()
    {
        _textField = GetComponent<TextMeshProUGUI>();
    }

    protected override void UpdateHealthInfo(int health)
    {
        _textField.text = $"{health} / {PlayerHealth.MaxValue}";
    }
}
