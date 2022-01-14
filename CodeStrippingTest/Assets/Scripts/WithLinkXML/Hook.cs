using System;
using System.Reflection;

namespace WithLinkXML
{
    public class Hook
    {
        // Target is the property target of the hook with a getter.
        public object Target { get; }
        
        // MethodName is the method name property of the hook with a getter.
        public string MethodName { get; }
        
        public Hook(object target, string methodName)
        {
            Target = target;
            MethodName = methodName;

            MethodInfo methodInfo = target.GetType().GetMethod(methodName);
            if (methodInfo == null) throw new Exception("Provided hook method doesn't exist");
        }
        
        public void CallHooksImpl()
        {
            MethodInfo methodInfo = Target.GetType().GetMethod(MethodName);
            object[] args = new object[] {};
            var result = methodInfo.Invoke(Target, args);
        }
    }
}