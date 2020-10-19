public abstract class Objective
{
    #region Ctors
    public Objective() { }
    #endregion Ctors

    #region Properties
    public abstract string Description { get; }
    public virtual float TargetValue { get; protected set; }
    public bool IsComplete { get; protected set; }
    #endregion Properties

    #region Methods
    public virtual void CompleteGoal()
    {
        IsComplete = true;
    }
    #endregion Methods
}
