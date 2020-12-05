public class WidgetObjective : Objective
{
    #region Members
    private float _baseTarget = 50f;
    #endregion Members

    #region Ctor
    public WidgetObjective(float targetModifier) => TargetValue = targetModifier * _baseTarget;
    #endregion Ctor

    #region Properties
    public override string Description => $"Build {TargetValue} widgets";
    #endregion Properties
}