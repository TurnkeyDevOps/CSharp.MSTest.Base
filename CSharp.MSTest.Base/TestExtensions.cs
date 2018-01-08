using System;
using System.Linq.Expressions;
using System.Reflection;

namespace CSharp.MSTest.Base
{
    /// <summary>
    /// BDD Style Extensions that can be used with MSTest, NUnit, or any Testing Framework
    /// </summary>
    public static class TestExtensions
    {

        /// <summary>
        /// Throws an exception if the actual does not equal the expected
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="actual">The actual.</param>
        /// <param name="expected">The expected.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="TestException">
        /// </exception>
        public static void ShouldEqual<T>(this T actual, T expected, string message = null) where T : IComparable
        {
            message = message ?? string.Format("Expected {0} to be equal to {1}", actual, expected);

            if (actual == null && expected != null)
                throw new TestException(message);

            if (actual != null && actual.CompareTo(expected) != 0)
                throw new TestException(message);
        }

        /// <summary>
        /// Calls a non public void method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="parameters">The parameters.</param>
        /// <exception cref="ArgumentNullException">obj</exception>
        /// <exception cref="TestException"></exception>
        public static void CallNonPublicVoidMethod<T>(this T obj, string methodName, params object[] parameters)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (String.IsNullOrEmpty(methodName))
                throw new ArgumentNullException(nameof(methodName));

            var method = obj.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

            if (method == null)
                throw new TestException(string.Format("Cannot get method {0} for type {1}", methodName, obj.GetType().FullName));

            method.Invoke(obj, parameters);
        }

        /// <summary>
        /// Calls a non public non void method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TRet">The type of the t ret.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>TRet.</returns>
        /// <exception cref="ArgumentNullException">
        /// obj
        /// or
        /// methodName
        /// </exception>
        /// <exception cref="TestException"></exception>
        public static TRet CallNonPublicNonVoidMethod<T, TRet>(this T obj, string methodName, params object[] parameters)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (String.IsNullOrEmpty(methodName))
                throw new ArgumentNullException(nameof(methodName));

            var method = obj.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

            if (method == null)
                throw new TestException(string.Format("Cannot get method {0} for type {1}", methodName, obj.GetType().FullName));

            return (TRet) method.Invoke(obj, parameters);
        }

        /// <summary>
        /// Sets the property of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TRet">The type of the t ret.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="TestException">The expression provided is not a property.</exception>
        public static void SetProperty<T, TRet>(this T obj, Expression<Func<T, TRet>> expression, TRet value)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new TestException("The expression provided is not a property.");

            ((PropertyInfo)memberExpression.Member).SetValue(obj, value, null);
        }

        /// <summary>
        /// Sets the non public field of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TField">The type of the t field.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <exception cref="ArgumentNullException">
        /// obj
        /// or
        /// propertyName
        /// </exception>
        public static void SetNonPublicField<T, TField>(this T obj, string propertyName, TField propertyValue)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (String.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException(nameof(propertyName));


            typeof(T).GetField(propertyName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(obj, propertyValue);
        }

        /// <summary>
        /// Gets a non public field of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TRet">The type of the t ret.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>TRet.</returns>
        /// <exception cref="ArgumentNullException">
        /// obj
        /// or
        /// fieldName
        /// </exception>
        /// <exception cref="TestException"></exception>
        public static TRet GetNonPublicField<T, TRet>(this T obj, string fieldName)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (String.IsNullOrEmpty(fieldName))
                throw new ArgumentNullException(nameof(fieldName));

            var field = typeof(T).GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

            if (field == null)
                throw new TestException(string.Format("Cannot get field {0} for type {1}", fieldName, obj.GetType().FullName));

            return (TRet)field.GetValue(obj);
        }

        /// <summary>
        /// Gets a non public property of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TRet">The type of the t ret.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>TRet.</returns>
        /// <exception cref="ArgumentNullException">
        /// obj
        /// or
        /// propertyName
        /// </exception>
        /// <exception cref="TestException"></exception>
        public static TRet GetNonPublicProperty<T, TRet>(this T obj, string propertyName)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (String.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException(nameof(propertyName));

            var property = typeof(T).GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic);

            if (property == null)
                throw new TestException(string.Format("Cannot get property {0} for type {1}", propertyName, obj.GetType().FullName));

            return (TRet)property.GetValue(obj, null);
        }
    }
}
