using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Trinity;
using Trinity.Storage;

namespace storage3
{
    public class storage3
    {
        [Test]
        public void T1()
        {
            for (int i = 0; i < 256; i++)
            {
                Global.LocalStorage.SaveCell(i, new byte[] { 0 });
            }
            for (int i = 0; i < 256; i++)
            {
                Global.LocalStorage.RemoveCell(i);
            }

            Assert.AreEqual(0, (int)Global.LocalStorage.CellCount);
        }
    }
}
