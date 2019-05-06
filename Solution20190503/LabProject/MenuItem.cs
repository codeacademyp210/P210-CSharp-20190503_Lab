using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public partial class MenuItem : Component
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        public MenuItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
