using System;
using System.Xml;

namespace Weepoo_QuanLyCuaHangThucAnNhanh.Model
{
    internal class XMLFile
    {
        internal XmlDocument getXmlDocument(string v)
        {
            XmlDocument Xd = new XmlDocument();
            Xd.Load(v);
            return Xd;
        }
    }
}