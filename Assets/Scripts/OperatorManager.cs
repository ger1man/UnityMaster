using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OperatorManager : MonoBehaviour {
    public HexGrid hexGrid;
    HexCell currentCell;
    public Unit selectedUnit;
    HexCell GetCellUnderCursor()
    {
        return
            hexGrid.GetCell(Camera.main.ScreenPointToRay(Input.mousePosition));
    }

    void CreateUnit()
    {
        HexCell cell = GetCellUnderCursor();
        Debug.Log(cell.coordinates.ToString());
        if (cell && !cell.Unit)
        {
            hexGrid.AddUnit(
                Instantiate(selectedUnit), cell, Random.Range(0f, 360f)
            );
        }
    }
    void Start()
    {


    }
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButton(0))
            {
                CreateUnit();
                return;
            }
        }
    }
    public void SetEditMode(bool toggle)
    {
        enabled = !toggle;
        Debug.Log("Switch Mode to Game");
    }
}
