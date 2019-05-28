using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.Bus;

namespace QuanLyNhaKho.GUI
{
    public partial class TrangThaiHangHoa : Form
    {
        TrangThaiHangHoa_bus bus = new TrangThaiHangHoa_bus();
        public TrangThaiHangHoa()
        {
            InitializeComponent();
        }

        private void TrangThaiHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TRANGTHAIHANGHOA' table. You can move, or remove it, as needed.
            this.tRANGTHAIHANGHOATableAdapter.Fill(this.dataSet1.TRANGTHAIHANGHOA);

        }
    }
}
