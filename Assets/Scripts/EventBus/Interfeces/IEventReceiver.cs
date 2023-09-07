public interface IEventReceiver<T> : IBaceEventReceiver // Параметризированный интерфейс принимающий тип события
    where T : struct, IEvenet
{
    void OnEvent(T var);
}
