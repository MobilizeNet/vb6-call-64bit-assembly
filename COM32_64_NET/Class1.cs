using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project2
{
    [Guid("D7B47BAF-CDB1-41AA-BA3A-FD734121DD16")]
    [ComVisible(true)][ProgId("Project2.Class1")][ClassInterface(ClassInterfaceType.AutoDual)]
	public class Class1
	{

		public void Foo()
		{
			MessageBox.Show("Foo from Class1 ");
		}
	}
}