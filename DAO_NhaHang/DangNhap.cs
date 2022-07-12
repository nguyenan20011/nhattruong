using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhaHang
{
    public partial class DangNhap : Component
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public DangNhap(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
