using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthActionSimulator : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Affect);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Affect);
    }

    public abstract void Affect();
}