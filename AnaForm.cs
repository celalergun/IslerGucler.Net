﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslerGucler.Net
{
    public partial class AnaForm : Form
    {
        private IslerGuclerDB _db = null;
        public AnaForm()
        {
            InitializeComponent();
            _db = new IslerGuclerDB();
            _db.Database.CreateIfNotExists();
            var isler = _db.Isler.ToList();
            dataGridView1.DataSource = isler;
        }
    }
}
