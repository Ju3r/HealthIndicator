using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBarView : HealthView
{
    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        Init();
    }

    public override void UpdateUI()
    {
        _slider.value = Health.Value;
    }

    protected virtual void Init()
    {
        _slider.maxValue = Health.MaxValue;
        _slider.value = _slider.maxValue;
    }
}
