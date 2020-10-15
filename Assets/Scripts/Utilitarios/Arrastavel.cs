using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Drag and drop script para ser utilizado com objetos da UI/Canvas
public class Arrastavel : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

    private Canvas canvas;

    private Transform pai;

    private RectTransform rectTransform;

    private CanvasGroup canvasGroup;

    public Vector2 anchoredPositionInicial { get; private set; }

    // Útil para quando a ação de arrastar é inválida mas só é possível verificar
    // no OnDrop de outro objeto
    public bool devoVoltarParaAnchoredPositionInicialAposSerArrastado;

    public event Action<Arrastavel> OnEndDragEvent;

    void Start()
    {
        canvas = GetComponentInParent<Canvas>();

        pai = transform.parent;

        rectTransform = GetComponent<RectTransform>();

        // Canvas Group é adicionado ao objeto para alterar o blocksRaycasts dele
        if (!GetComponent<CanvasGroup>())
            canvasGroup = this.gameObject.AddComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Salvar posição original
        anchoredPositionInicial = this.rectTransform.anchoredPosition;

        // Desabilitar o bloqueio de raycasts para que quando o jogador soltar
        // este objeto, o click atravesse o mesmo e acerte o objeto que estará
        // em baixo (que pode implementar um handler para o click)
        canvasGroup.blocksRaycasts = false;
        // Reestabelecer o pai deste objeto para que este seja o último dos irmãos
        // Desse modo, o objeto é arrastado e renderizado sobre os irmãos
        this.transform.SetParent(null);
        this.transform.SetParent(pai);
    }

    public void OnDrag(PointerEventData eventData)
    {
        // canvas.scaleFactor está aqui para manter o objeto exatamente sob o cursor
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        CancelDrag(eventData);
        OnEndDragEvent?.Invoke(this);
    }

    private void CancelDrag(PointerEventData eventData)
    {
        eventData.pointerDrag = null;
        canvasGroup.blocksRaycasts = true;

        if (devoVoltarParaAnchoredPositionInicialAposSerArrastado)
            this.rectTransform.anchoredPosition = anchoredPositionInicial;
    }
}
