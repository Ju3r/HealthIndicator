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

    private void Init()
    {
        _slider.value = Health.Value / Health.MaxValue;
    }

    public override void UpdateUI()
    {
        _slider.value = Health.Value / Health.MaxValue;
    }
}
