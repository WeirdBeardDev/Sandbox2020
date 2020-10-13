using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWall : MonoBehaviour
{
    #region Members
    [SerializeField] private Transform _wallParent = default;
    [SerializeField] private Material _brickWall = default;
    [SerializeField] private Material _logWall = default;
    #endregion Members

    #region Properties
    private Material CurrentWallMaterial => _wallParent.GetChild(0).GetComponent<MeshRenderer>().material;
    #endregion Properties

    #region Methods
    public void UpdateWall()
    {
        Material newWall = GetNextMaterial();

        foreach (Transform item in _wallParent)
        {
            item.GetComponent<MeshRenderer>().material = newWall;
        }
    }
    #endregion Methods

    #region Helpers
    private Material GetNextMaterial()
    {
        if (CurrentWallMaterial.name.Contains("Brick"))
        {
            print("Switch wall to logs...");
            return _logWall;
        }
        else
        {
            print("Switch wall to bricks...");
            return _brickWall;
        }
    }
    #endregion Helpers
}
