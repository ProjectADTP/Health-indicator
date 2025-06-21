using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderBarHP : HealthBar
{
    private Slider _healthSlider;

    private float _ratio = 100;

    private void Awake()
    {
        _healthSlider = GetComponent<Slider>();
    }

    protected override void UpdateHealthInfo(int health)
    {
        _healthSlider.value = health / _ratio;
    }
}
