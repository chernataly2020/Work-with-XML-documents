using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml.Schema;

namespace Работа_с_XML_документами
{
    public partial class Form1 : Form
    {
        ArrayList orders = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создает новый документ
        /// </summary>
        
        private void создатьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orders.Clear();
            ShowOrders();
        }

        /// <summary>
        /// Отображает заказы в виде дерева
        /// </summary>
        void ShowOrders()
        {
            treeView.BeginUpdate();

            treeView.Nodes.Clear();
            TreeNode root = new TreeNode("Заказы");
            treeView.Nodes.Add(root);

            foreach (Order order in orders)
            {
                TreeNode nodeOrder = new TreeNode(string.Format("поставляется по адресу --> {0} --> дата поставки --> ({1})", order.Address, order.Date.ToShortDateString()));

                foreach (Good good in order.Goods)
                    nodeOrder.Nodes.Add(new TreeNode(string.Format("Заказанный товар --> {0} --> имеет цену --> ({1} рублей)", good.Name, good.Price)));

                root.Nodes.Add(nodeOrder);
            }

            treeView.SelectedNode = treeView.Nodes[0];
            treeView.ExpandAll();
            treeView.EndUpdate();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Сохраняем данные в файл
        /// </summary>
        private void СохранитьДокумент_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.FileName = "заказы";
            saveDlg.DefaultExt = "xml";
            saveDlg.Filter = "Файлы XML (*.xml)|*.xml";

            if (saveDlg.ShowDialog() != DialogResult.OK)
                return;

            XmlTextWriter writer = null;

            try
            {
                writer = new XmlTextWriter(saveDlg.FileName, System.Text.Encoding.Unicode);

                writer.WriteStartDocument();
                writer.WriteStartElement("Заказы");

                // сохраняем заказы
                foreach (Order order in orders)
                {
                    writer.WriteStartElement("Заказ");
                    writer.WriteAttributeString("Адрес", order.Address);
                    writer.WriteAttributeString("Дата", order.Date.ToShortDateString());

                    // сохраняем товар
                    foreach (Good good in order.Goods)
                    {
                        writer.WriteStartElement("Товар");
                        writer.WriteAttributeString("Название", good.Name);
                        writer.WriteAttributeString("Цена", good.Price.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавляет заказ
        /// </summary>
        private void ДобавитьЗаказ_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(Адрес.Text, ДатаЗаказа.Value));
            Адрес.Text = string.Empty;
            ShowOrders();
        }

        /// <summary>
        /// Открывает документ с помощью XmlDocument
        /// </summary>
        private void сПомощьюXmlDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Файлы XML (*.xml)|*.xml";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            XmlDocument doc = new XmlDocument();
            orders.Clear();

            try
            {
                doc.Load(dlg.FileName);

                // получаем все заказы
                XmlNodeList ordersList = doc.DocumentElement.ChildNodes;

                foreach (XmlNode nodeOrder in ordersList)
                {
                    Order order = new Order(nodeOrder.Attributes["Адрес"].Value, DateTime.Parse(nodeOrder.Attributes["Дата"].Value));

                    // получаем все товары из заказа
                    XmlNodeList goodsList = nodeOrder.ChildNodes;

                    foreach (XmlNode nodeGood in goodsList)
                        order.AddGood(nodeGood.Attributes["Название"].Value, float.Parse(nodeGood.Attributes["Цена"].Value));

                    orders.Add(order);
                }

                ShowOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        /// <summary>
        /// Открывает документ с помощью XmlTextReader
        /// </summary>
        private void сПомощьюXmlTextReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Файлы XML (*.xml)|*.xml";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            XmlTextReader reader = null;
            orders.Clear();

            try
            {
                reader = new XmlTextReader(dlg.FileName);
                reader.WhitespaceHandling = WhitespaceHandling.None;	// пропускаем пустые узлы

                while (reader.Read())
                    if (reader.NodeType == XmlNodeType.Element)
                        if (reader.Name == "Заказ")
                        {
                            Order order = new Order(reader.GetAttribute("Адрес"), DateTime.Parse(reader.GetAttribute("Дата")));

                            // получаем товары в заказе
                            while (reader.Read() && reader.Name == "Товар")
                                order.AddGood(reader.GetAttribute("Название"), float.Parse(reader.GetAttribute("Цена")));

                            orders.Add(order);
                        }


                ShowOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <summary>
        /// Открывает документ с помощью XmlValidationgReader
        /// </summary>
        private void сПомощьюXmlValidationgReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Файлы XML (*.xml)|*.xml";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            string file = dlg.FileName;

            // получаем имя файла со схемой
            dlg.Filter = "Файлы XSD (*.xsd)|*.xsd";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            string schema = dlg.FileName;

            XmlValidatingReader readerVal = null;
            orders.Clear();

            try
            {
                XmlTextReader reader = new XmlTextReader(file);
                reader.WhitespaceHandling = WhitespaceHandling.None;	// пропускаем пустые узлы

                readerVal = new XmlValidatingReader(reader);
                readerVal.Schemas.Add("", schema);
                readerVal.ValidationType = ValidationType.Schema;
                readerVal.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandle);

                while (readerVal.Read())
                    if (readerVal.NodeType == XmlNodeType.Element)
                        if (readerVal.Name == "Заказ")
                        {
                            Order order = new Order(readerVal.GetAttribute("Адрес"), DateTime.Parse(readerVal.GetAttribute("Дата")));

                            // получаем товары в заказе
                            while (readerVal.Read() && readerVal.Name == "Товар")
                                order.AddGood(readerVal.GetAttribute("Название"), float.Parse(readerVal.GetAttribute("Цена")));

                            orders.Add(order);
                        }

                ShowOrders();
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                if (readerVal != null)
                    readerVal.Close();
            }
        }

        public void ValidationEventHandle(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Error)
                throw new XmlException("Неверный формат XML файла: " + args.Message);

            MessageBox.Show("Предупреждение формата XML файла: " + args.Message);
        }

        /// <summary>
        /// Добавляет товар в заказ
        /// </summary>
        private void ДобавитьТовар_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null || treeView.SelectedNode.Parent != treeView.Nodes[0])
            {
                MessageBox.Show("Выберете заказ, к которому добавляется товар!");
                return;
            }

            float price = 0;

            try
            {
                price = float.Parse(Цена.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Укажите цену товара!");
                return;
            }

            ((Order)orders[treeView.SelectedNode.Index]).AddGood(НазваниеТовара.Text, price);

            НазваниеТовара.Text = string.Empty;
            Цена.Text = string.Empty;
            ShowOrders();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutProgram f = new AboutProgram();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
