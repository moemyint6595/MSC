using System.Linq.Expressions;
using System.Reflection;

namespace MSCShared.Extensions
{
    public static class ObjectCloner
    {
        private static readonly Dictionary<Type, Delegate> CachedCloners = new();

        public static T Clone<T>(T obj)
        {
            if (obj == null) return default;

            Type type = typeof(T);

            if (!CachedCloners.TryGetValue(type, out var cloner))
            {
                cloner = CreateCloner<T>();
                CachedCloners[type] = cloner;
            }

            return ((Func<T, T>)cloner)(obj);
        }

        private static Func<T, T> CreateCloner<T>()
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "source");
            List<MemberBinding> bindings = new();

            foreach (var property in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                         .Where(p => p.CanRead && p.CanWrite))
            {
                bindings.Add(Expression.Bind(property, Expression.Property(parameter, property)));
            }

            foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                bindings.Add(Expression.Bind(field, Expression.Field(parameter, field)));
            }

            Expression body = Expression.MemberInit(Expression.New(typeof(T)), bindings);
            return Expression.Lambda<Func<T, T>>(body, parameter).Compile();
        }
    }

}
