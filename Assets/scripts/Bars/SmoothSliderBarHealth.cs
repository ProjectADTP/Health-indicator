using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

[RequireComponent(typeof(Slider))]
public class SmoothSliderBarHP : HealthBar
{
    private Slider _healthSlider;

    private float _currentDisplayHealth;
    private float _ratio;
    private float _smoothTime = 0.0075f;

    private Coroutine _smoothCoroutine;
    private bool _isSmoothing;

    private void Awake()
    {
        _ratio = PlayerHealth.MaxValue;

        _healthSlider = GetComponent<Slider>();
    }

    protected override void UpdateHealthInfo(int health)
    {
        if (_isSmoothing)
        {
            StopCoroutine(_smoothCoroutine);
        }

        _smoothCoroutine = StartCoroutine(SmoothHealthUpdate(health));
    }

    private IEnumerator SmoothHealthUpdate(int health)
    {
        _isSmoothing = true;

        while (Mathf.Approximately(_currentDisplayHealth, health / _ratio) == false)
        {
            _currentDisplayHealth = Mathf.MoveTowards(_currentDisplayHealth,
                                                health / _ratio,
                                                _smoothTime * Time.deltaTime * _ratio);
            DisplayHealth();

            yield return null;
        }

        _currentDisplayHealth = health / _ratio;

        DisplayHealth();

        _isSmoothing = false;
    }

    private void DisplayHealth()
    {
        _healthSlider.value = _currentDisplayHealth;
    }
}
