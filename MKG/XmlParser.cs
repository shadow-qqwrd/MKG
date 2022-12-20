using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
namespace MKG
{
    internal class XmlParser
    {
        public Test GetTestByThemaName(string selectedTest)
        {
            try
            {
                Test test = new Test();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("test.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                if (xRoot != null)
                {
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Attributes.GetNamedItem("text").Value.ToString() == selectedTest)
                        {

                            test.thema = xnode.Attributes.GetNamedItem("text").Value.ToString();
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                //проход по question
                                Question question = new Question();
                                question.text = childnode.Attributes.GetNamedItem("text").Value.ToString();
                                question.variants = new List<Variant>();
                                foreach (XmlNode child in childnode.ChildNodes)
                                {
                                    //проход по variant
                                    question.variants.Add(new Variant(child.InnerText, Convert.ToInt32(child.Attributes.GetNamedItem("isTrue").Value) == 1));
                                }
                                test.questions.Add(question);
                            }
                            return test;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

