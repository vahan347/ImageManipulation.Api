namespace ImageManipulation.Api.Services
{
    public interface IManipulation<T>
    {
        T Resize(T image);

        T Blur(T image);

        T ApplyEffect(T image);
    }
}
