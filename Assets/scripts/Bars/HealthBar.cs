using TMPro;
using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected PlayerHealth PlayerHealth;

    protected void Start()
    {
        UpdateHealthInfo(PlayerHealth.Value);
    }

    protected void OnEnable()
    {
        PlayerHealth.ChangedHealth += UpdateHealthInfo;
    }

    protected void OnDisable()
    {
        PlayerHealth.ChangedHealth -= UpdateHealthInfo;
    }

    protected abstract void UpdateHealthInfo(int health);
}
