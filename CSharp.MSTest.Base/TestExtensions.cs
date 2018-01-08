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
        #region ShouldNotBeZero
        public static void ShouldNotBeZero(this float value, string message = null)
        {
            message = message ?? string.Format("Expected {0} not to be zero", value);

            if (value == 0)
                throw new TestException(message);
        }

        public static void ShouldNotBeZero(this short value, string message = null)
        {
            message = message ?? string.Format("Expected {0} not to be zero", value);

            if (value == 0)
                throw new TestException(message);
        }

        public static void ShouldNotBeZero(this decimal value, string message = null)
        {
            message = message ?? string.Format("Expected {0} not to be zero", value);

            if (value == 0)
                throw new TestException(message);
        }

        public static void ShouldNotBeZero(this double value, string message = null)
        {
            message = message ?? string.Format("Expected {0} not to be zero", value);

            if (value == 0)
                throw new TestException(message);
        }

        public static void ShouldNotBeZero(this int value, string message = null)
        {
            message = message ?? string.Format("Expected {0} not to be zero", value);

            if (value == 0)
                throw new TestException(message);
        }

        public static void ShouldNotBeZero(this long value, string message = null)
        {
            message = message ?? string.Format("Expected {0} not to be zero", value);

            if (value == 0)
                throw new TestException(message);
        }
        #endregion

        #region ShouldBeZero
        public static void ShouldBeZero(this float value, string message = null)
        {
            message = message ?? string.Format("Expected {0} to be zero", value);

            if (value != 0)
                throw new TestException(message);
        }

        public static void ShouldBeZero(this short value, string message = null)
        {
            message = message ?? string.Format("Expected {0} to be zero", value);

            if (value != 0)
                throw new TestException(message);
        }

        public static void ShouldBeZero(this double value, string message = null)
        {
            message = message ?? string.Format("Expected {0} to be zero", value);

            if (value != 0)
                throw new TestException(message);
        }

        public static void ShouldBeZero(this decimal value, string message = null)
        {
            message = message ?? string.Format("Expected {0} to be zero", value);

            if (value != 0)
                throw new TestException(message);
        }

        public static void ShouldBeZero(this int value, string message = null)
        {
            message = message ?? string.Format("Expected {0} to be zero", value);

            if (value != 0)
                throw new TestException(message);
        }

        public static void ShouldBeZero(this long value, string message = null)
        {
            message = message ?? string.Format("Expected {0} to be zero", value);

            if (value != 0)
                throw new TestException(message);
        }


        #endregion


        #region ShouldBeGreaterThan

        public static void ShouldBeGreaterThan(this int value, int valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be greater than {1}", value, valueToCompare);

            if (value <= valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeGreaterThan(this long value, long valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be greater than {1}", value, valueToCompare);

            if (value <= valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeGreaterThan(this short value, short valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be greater than {1}", value, valueToCompare);

            if (value <= valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeGreaterThan(this decimal value, decimal valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be greater than {1}", value, valueToCompare);

            if (value <= valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeGreaterThan(this float value, float valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be greater than {1}", value, valueToCompare);

            if (value <= valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeGreaterThan(this double value, double valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be greater than {1}", value, valueToCompare);

            if (value <= valueToCompare)
                throw new TestException(message);
        }

        #endregion

        #region ShouldBeLessThan

        public static void ShouldBeLessThan(this float value, float valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be less than {1}", value, valueToCompare);

            if (value > valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeLessThan(this double value, double valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be less than {1}", value, valueToCompare);

            if (value > valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeLessThan(this decimal value, decimal valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be less than {1}", value, valueToCompare);

            if (value > valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeLessThan(this int value, int valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be less than {1}", value, valueToCompare);

            if (value > valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeLessThan(this long value, long valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be less than {1}", value, valueToCompare);

            if (value > valueToCompare)
                throw new TestException(message);
        }

        public static void ShouldBeLessThan(this short value, short valueToCompare, string message = null)
        {
            message = message ?? string.Format("{0} should be less than {1}", value, valueToCompare);

            if (value > valueToCompare)
                throw new TestException(message);
        }
        #endregion

        public static void ShouldContain(this string value, string containValue, string message = null)
        {
            message = message ?? string.Format("{0} should contain {1}", value, containValue);

            if (value == null || !value.Contains(containValue))
                throw new TestException(message);
        }

        public static void ShouldNotContain(this string value, string containValue, string message = null)
        {
            message = message ?? string.Format("{0} should not contain {1}", value, containValue);

            if (value != null && value.Contains(containValue))
                throw new TestException(message);
        }

        public static void ShouldBeTrue(this bool value, string message = null)
        {
            message = message ?? "Expected value to be true but was false";

            if (!value)
                throw new TestException(message);
        }

        public static void ShouldBeFalse(this bool value, string message = null)
        {
            message = message ?? "Expected value to be false but was true";

            if (value)
                throw new TestException(message);
        }

        public static void ShouldBeNullOrEmpty(this string value, string message = null)
        {
            message = message ?? "Expected to be null or empty but was " + value;

            if (!String.IsNullOrEmpty(value))
                throw new TestException(message);
        }

        public static void ShouldNotBeNullOrEmpty(this string value, string message = null)
        {
            message = message ?? "Expected to not be null or empty but was " + value;

            if (String.IsNullOrEmpty(value))
                throw new TestException(message);
        }

        public static void ShouldBeNull(this object value, string message = null)
        {
            message = message ?? "Expected to be null but was " + value;

            if (value != null)
                throw new TestException(message);
        }

        public static void ShouldNotBeNull(this object value, string message = null)
        {
            message = message ?? "Expected not to be null but was (null)";

            if (value == null)
                throw new TestException(message);
        }

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

            return (TRet)method.Invoke(obj, parameters);
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