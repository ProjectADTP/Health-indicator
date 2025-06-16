using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderBarHP : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private TextMeshProUGUI _textField;

    private Slider _healthSlider;

    private float _ratio = 100;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void Start()
    {
        UpdateHealthSlider();
    }

    private void OnEnable()
    {
        _playerHealth.OnHealthChanged += UpdateHealthSlider;
    }

    private void OnDisable()
    {
        _playerHealth.OnHealthChanged -= UpdateHealthSlider;
    }

    private void UpdateHealthSlider()
    {
        _textField.text = _playerHealth.Health.ToString() + '%';

        _healthSlider.value = _playerHealth.Health / _ratio;
    }
}
