using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Teste1
    {
        private Text logText;

        public Teste1(Text logText)
        {
            this.logText = logText;
        }

        public void CallTest1()
        {
            var msg = "Teste1->CallTeste1()";
            Debug.unityLogger.Log(msg);
            logText.text = msg;
        }
    }


[Preserve]
public class Foo
{
    [Preserve]
    public void SomeMethod() {}
}
}