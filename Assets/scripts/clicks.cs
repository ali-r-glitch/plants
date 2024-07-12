using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clicks : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Material redmat;
    private Renderer objectRenderer;
    private Material originalMaterial;
    bool follow = false;
    GameObject gamemanager;
    GameObject paneldis;
    paneldisplay pnldis;
    stats sta;

    private GridManager gridManager;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
        gamemanager = GameObject.Find("gamemanager");
        paneldis = GameObject.Find("Paneldisplay");
        pnldis = paneldis.GetComponent<paneldisplay>();
        sta = this.gameObject.GetComponent<stats>();

        // Find and assign the GridManager
        gridManager = FindObjectOfType<GridManager>();
        if (gridManager == null)
        {
            Debug.LogError("GridManager not found in the scene.");
        }
    }

    private void FixedUpdate()
    {
        if (follow)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = worldPosition;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(" down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("up ");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(" click ");
        follow = !follow;

        if (!follow && gridManager != null)
        {
            transform.position = gridManager.GetNearestPointOnGrid(transform.position);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(" exit ");
        objectRenderer.material = originalMaterial;
        pnldis.display = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(" enter");
        objectRenderer.material = redmat;
        pnldis.display = true;
        pnldis.setdisplay(sta.health, sta.damage, sta.picturenum, sta.effect, sta.name);
    }
}
