namespace ValueInjector
{
    public interface IValueInjection
    {
        object Map(object source, object target);
    }
}