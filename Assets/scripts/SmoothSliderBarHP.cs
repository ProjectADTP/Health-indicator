using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothSliderBarHP : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private TextMeshProUGUI _textField;

    private Slider _healthSlider;

    private float _currentDisplayHealth;
    private float _ratio = 100;
    private float _smoothTime = 0.0075f; 

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _playerHealth.OnHealthChanged += UpdateHealthSlider;

        UpdateHealthSlider();
    }

    private void OnDisable()
    {
        _playerHealth.OnHealthChanged -= UpdateHealthSlider;
    }

    private void Update()
    {
        if (_currentDisplayHealth != _playerHealth.Health / _ratio)
        {
            _currentDisplayHealth = Mathf.MoveTowards(
                _currentDisplayHealth,
                _playerHealth.Health / _ratio,
                _smoothTime * Time.deltaTime * _ratio
            );

            UpdateHealthSlider();
        }
    }

    private void UpdateHealthSlider()
    {
        _textField.text = ((int)(_currentDisplayHealth * _ratio)).ToString() + '%';

        _healthSlider.value = _currentDisplayHealth;
    }
}
