using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ATM
{
    internal class DataMeneger
    {
        string path = "ListOfOperations.xml";

        public DataMeneger()
        {

        }

        public void AddOperation(Operation operation)
        {
            XmlDocument Doc = new XmlDocument();
            if (File.Exists(path))
            {
                Doc.Load(path);
            }
            else
            {
                XmlElement Rootnew = Doc.CreateElement("Operations");
                Doc.AppendChild(Rootnew);
                Doc.Save(path);
            }
            XmlElement Root = Doc.DocumentElement;
            XmlElement xmlOp = Doc.CreateElement("operation");

            XmlElement xmlBank = Doc.CreateElement("bank");
            XmlElement xmlPerson = Doc.CreateElement("person");
            XmlElement xmlDoing = Doc.CreateElement("doing");
            XmlElement xmlMoney = Doc.CreateElement("transfer");

            xmlBank.InnerText = operation.NumBank;
            xmlPerson.InnerText = operation.Person;
            xmlDoing.InnerText = operation.DoingSt();
            xmlMoney.InnerText = operation.MoneyTransfer.ToString();

            xmlOp.AppendChild(xmlBank);
            xmlOp.AppendChild(xmlPerson);
            xmlOp.AppendChild(xmlMoney);
            xmlOp.AppendChild(xmlDoing);

            Root.AppendChild(xmlOp);
            Doc.Save(path);
        }

        public List<Operation> ReturnListOp()
        {
            List<Operation> returnList = new List<Operation>();

            if (!File.Exists(path))
            {
                Operation op = null;
                returnList.Add(op);
                return returnList;
            }
            XmlDocument Doc = new XmlDocument();
            Doc.Load(path);
            XmlElement OperationsXml = Doc.DocumentElement;
            foreach(XmlNode opXml in OperationsXml)
            {
                string numBank = opXml["bank"].InnerText;
                string person = opXml["person"].InnerText;
                decimal transfer = decimal.Parse(opXml["transfer"].InnerText);

                string dSt = opXml["doing"].InnerText;
                bool doing;
                if(dSt == "Внести в банкомант")
                {
                    doing = true;
                }
                else
                {
                    doing = false;
                }
                Operation newOp = new Operation(numBank, person, transfer, doing);

                returnList.Add(newOp);
            }

            return returnList;

        }

    }
}
