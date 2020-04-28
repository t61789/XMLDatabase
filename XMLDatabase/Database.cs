using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLDatabase
{
    public class Database
    {
        public string filePath;

        private XDocument doc;

        private DataTable dataTable;

        public Database(string filePath,DataGridView gridView)
        {
            this.filePath = filePath;
            doc = XDocument.Load(filePath);

            dataTable = new DataTable();

            foreach (var item in doc.Root.Element("fields").Elements())
            {
                dataTable.Columns.Add(item.Name.ToString());
            }
            if (dataTable.Columns.Count == 0)
                return;

            dataTable.Rows.Clear();
            foreach (var item in doc.Root.Element("rows").Elements())
            {
                DataRow row = dataTable.NewRow();
                int count = 0;
                foreach (var j in item.Elements())
                {
                    row[count]= j.Value;
                    count++;
                }
                dataTable.Rows.Add(row);
            }

            gridView.DataSource = dataTable;

            Main_form.instance.SetTitle(filePath);
        }

        public void Save()
        {
            Save(filePath);
        }

        public void Save(string path)
        {
            XDocument doc = new XDocument();
            doc.Add(new XElement("root"));
            XElement cur = new XElement("fields");
            foreach (DataColumn item in dataTable.Columns)
                cur.Add(new XElement(item.ColumnName));
            doc.Root.Add(cur);

            cur = new XElement("rows");
            foreach (DataRow item in dataTable.Rows)
            {
                XElement row = new XElement("row");
                foreach (var t in item.ItemArray)
                    row.Add(new XElement("t") { Value = t.ToString() });
                cur.Add(row);
            }
            doc.Root.Add(cur);
            doc.Save(path);

            filePath = path;

            Main_form.instance.SetTitle(filePath);
        }
    }
}
