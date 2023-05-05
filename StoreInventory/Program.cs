using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
namespace Store;

static class Program{   //mainklassen
    public static void Main(){  //gör en dairystore och kör run funktionen i den.
        DairyStore dairyStore = new();
        dairyStore.Run();
    }
}

