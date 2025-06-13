using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBarView : HealthView
{
    protected Slider Slider;

    private void Awake()
    {
        Slider = GetComponent<Slider>();

        Init();
    }

    public override void UpdateUI()
    {
        Slider.value = Health.Value / Health.MaxValue;
    }

    private void Init()
    {
        Slider.value = Health.Value / Health.MaxValue;
    }
}
