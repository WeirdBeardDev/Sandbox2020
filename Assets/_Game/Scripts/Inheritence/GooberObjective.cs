public class GooberObjective : Objective
{
    #region Members
    private float _baseTarget = 25f;
    #endregion Members

    #region Ctor
    public GooberObjective(float targetModifier) => TargetValue = targetModifier * _baseTarget;
    #endregion Ctor

    #region Properties
    public override string Description => $"Reach {TargetValue} goobers";
    #endregion Properties
}