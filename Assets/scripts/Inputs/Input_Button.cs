using UnityEngine;
using UnityEngine.UI;

public abstract class Input_Button : MonoBehaviour
{
    [SerializeField] protected PlayerHealth Value;

    protected Button Button;

    protected int Health = 25;

    protected void Awake()
    {
        Button = GetComponent<Button>();
    }

    protected void OnEnable()
    {
        Button.onClick.AddListener(ChangeHealth);
    }

    protected void OnDisable()
    {
        Button.onClick.RemoveListener(ChangeHealth);
    }

    protected abstract void ChangeHealth();
}
