using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridFillButton_Click(object sender, EventArgs e)
        {
            var inputArray = ParseInput();
            var resultSort = BubbleSort(inputArray);
            var resultList = GetListCount(resultSort);
            resultGridView.DataSource = resultList;

        }

        IEnumerable<int> ParseInput()
        {
            var inputStr = inputTextBox.Text.Replace(" ", "");
            var inputArray = inputStr.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(c => TryParse(c)).Where(c => c != null);
            return inputArray.Cast<int>();
        }

        IEnumerable<int> BubbleSort(IEnumerable<int> inp)
        {
            var input = inp.ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
        
        IEnumerable<NumberDTO> GetListCount(IEnumerable<int> input)
        {
            Dictionary<int, NumberDTO> dict = new Dictionary<int, NumberDTO>();
            foreach (var item in input)
            {
                if(dict.ContainsKey(item))
                {
                    dict[item].Count++;
                }
                else
                {
                    dict.Add(item, new NumberDTO(item));
                }
            }
            return dict.Select(c=>c.Value).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultGridView.AutoGenerateColumns = false;
            resultGridView.Columns[0].Name = "Значение";
            resultGridView.Columns[0].DataPropertyName = "Num";
            resultGridView.Columns[1].Name = "Количество";
            resultGridView.Columns[1].DataPropertyName = "Count";
            
        }

        int? TryParse(string inp)
        {
            int res = 0;
            if (int.TryParse(inp, out res))
                return res;
            return null;
        }
    }
}
