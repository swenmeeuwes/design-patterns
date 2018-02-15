namespace Singleton
{
    abstract class StaticSingleton<T> where T : new()
    {
        private static readonly T _instance = new T();
        public static T Instance => _instance;
    }
}
