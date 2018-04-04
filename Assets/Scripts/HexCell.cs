using UnityEngine;
using UnityEngine.UI;
public class HexCell : MonoBehaviour {

	public HexCoordinates coordinates;

	public Color color;

    public Vector3 Position
    {
        get
        {
            return transform.localPosition;
        }
    }
    public Unit Unit { get; set; }

}