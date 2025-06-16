using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextBarHP : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;

    private TextMeshProUGUI _textField;

    private void Awake()
    {
        _textField = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        UpdateHealthText();
    }

    private void OnEnable()
    {
        _playerHealth.OnHealthChanged += UpdateHealthText;
    }

    private void OnDisable()
    {
        _playerHealth.OnHealthChanged -= UpdateHealthText;
    }

    private void UpdateHealthText()
    {
        _textField.text = $"{_playerHealth.Health} / {_playerHealth.MaxHealth}";
    }
}
