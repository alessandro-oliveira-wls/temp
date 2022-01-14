using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class ViewController : MonoBehaviour
{

    public Text LogText;
    
    public void CallHookWithLinkXML()
    {
        var invoker = new WithLinkXML.Hook(new Teste1(LogText), "CallTest1");
        invoker.CallHooksImpl();
    }

    public void CallHookPreserve()
    {
        var invoker = new WithPreserve.Hook(new Teste2(LogText), "CallTest2");
        invoker.CallHooksImpl();
    }
    
    public void CallHookWithLinkXMLAndNameof()
    {
        var invoker = new WithLinkXMLAndNameof.Hook(new Teste3(LogText), nameof(Teste3.CallTest3));
        invoker.CallHooksImpl();
    }

    public void CallHookPreserveAndNameof()
    {
        var invoker = new WithPreserveAndNameof.Hook(new Teste4(LogText), nameof(Teste4.CallTest4));
        invoker.CallHooksImpl();
    }

    public void CallUnpreservedHook()
    {
        var invoker = new Unpreserved.Hook(new Teste5(LogText), "CallTest5");
        invoker.CallHooksImpl();
    }

}
