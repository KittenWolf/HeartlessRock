namespace HeartlessRock.Models;

public class Target(Target.TargetSelector selector, Target.TargetModificator modificator, List<Enum> tags)
{
    public enum TargetSelector
    {
        Single,
        All
    }

    public enum TargetModificator
    {
        Basic,
        Random
    }

    public TargetSelector Selector = selector;
    public TargetModificator Modificator = modificator;

    public List<Enum> TargetTags => new(tags);
}
