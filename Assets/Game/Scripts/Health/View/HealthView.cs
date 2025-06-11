using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.HasChanged += UpdateUI;
    }

    private void OnDisable()
    {
        Health.HasChanged -= UpdateUI;
    }

    private void Start()
    {
        UpdateUI();
    }

    public abstract void UpdateUI();
}