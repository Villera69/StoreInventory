using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
namespace Store;

static class Program{
    public static void Main(){
        DairyStore dairyStore = new();
        dairyStore.Run();
    }
}

