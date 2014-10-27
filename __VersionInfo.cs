using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion("3.7.0.0")]
[assembly: AssemblyFileVersion("3.7.0.0")]


public class Version{
	static string GetVersion(){
        return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString()+"."+System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
    }  
}


