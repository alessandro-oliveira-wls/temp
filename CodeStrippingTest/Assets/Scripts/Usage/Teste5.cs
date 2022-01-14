using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Teste5
    {
        private Text logText;

        public Teste5(Text logText)
        {
            this.logText = logText;
        }


        public void CallTest5()
        {
            var msg = "Teste5->CallTeste5()";
            Debug.unityLogger.Log(msg);
            logText.text = msg;
        }
    }
}