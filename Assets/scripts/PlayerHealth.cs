using UnityEngine;
using System;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _value;

    private int _minValue = 0;
    private int _maxValue = 100;

    public int Value { get; private set; }
    public int MaxValue => _maxValue;

    public event Action<int> ChangedHealth;

    private void Awake()
    {
        Value = _value;
    }

    public void TakeDamage(int damage)
    {
        RestoreHealth(-damage);
    }

    public void RestoreHealth(int health)
    {
        if (health != 0)
            Value = Mathf.Clamp(health + Value, _minValue, _maxValue);
        else
            Value = _maxValue;

        ChangedHealth?.Invoke(Value);
    }
}