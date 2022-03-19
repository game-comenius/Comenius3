using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Slider))]
public abstract class BarControl : MonoBehaviour
{
    [System.Serializable] public class BarAnimationEnd : UnityEvent { }
    public BarAnimationEnd OnBarAnimationEnd;

    [SerializeReference] protected float animationTime;

    protected Slider slider;
    protected float progress;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0.0f;
        progress = 0.0f;
    }

    public virtual void UpdateBar() { }

    protected IEnumerator UpdateBarCoroutine()
    {
        float initialValue = slider.value;

        for (float i = 0; i <= animationTime; i += Time.deltaTime)
        {
            slider.value = initialValue + ((progress - initialValue) / animationTime) * i;
            yield return null;
        }

        slider.value = progress;  // Corretivo final para evitar erros de imprecisão

        OnBarAnimationEnd.Invoke();
        yield return null;
    }
}
