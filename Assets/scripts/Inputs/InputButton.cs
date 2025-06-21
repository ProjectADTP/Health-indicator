using UnityEngine;
using UnityEngine.UI;

public abstract class InputButton : MonoBehaviour
{
    [SerializeField] protected Health Value;

    protected Button Button;

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
