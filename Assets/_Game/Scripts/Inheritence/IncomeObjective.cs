public class IncomeObjective : Objective
{
    #region Members
    private float _baseTarget = 10f;
    #endregion Members

    #region Ctor
    public IncomeObjective(float targetModifier) => TargetValue = targetModifier * _baseTarget;
    #endregion Ctor

    #region Properties
    public override string Description => $"Reach {TargetValue} income per second";
    #endregion Properties
}